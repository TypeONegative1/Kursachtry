using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using GABENweb.Models;
using OfficeOpenXml;

namespace GABENweb.Controllers
{
    public class SaveExcelController : Controller
    {
        private static string downloadStatus = "";

        // GET: SaveExcel
        public ActionResult Index()
        {
            ViewBag.DownloadStatus = downloadStatus;
            return View();
        }

        [HttpPost]
        public ActionResult Download()
        {
            downloadStatus = "";
            try
            {
                return GenerateExcel();
            }
            catch (EmptyDbException)
            {
                downloadStatus = "Нет данных для наполнения таблицы.";
                Response.Redirect("Index");
            }
            catch (Exception)
            {
                downloadStatus = "Не получилось скачать файл.";
                Response.Redirect("Index");
            }
            return null;
        }

        private ActionResult GenerateExcel()
        {
            DbPlayer[] player;
            DbCurrency[] currencys;
            int[] currenciesCount;
            using (var db = new ApplicationDbContext())
            {
                player = db.DbPlayers.ToArray();
                currencys = db.DbCurrencies.ToArray();
                currenciesCount = new int[currencys.Length];
                if (player.Length < 1) throw new EmptyDbException();
                for (int i = 0; i < player.Length; i++)
                {
                    DbPlayer dbPlayer = db.DbPlayers.Find(player[i].Id);
                    currenciesCount[i] = dbPlayer.PrimaryRole.Count;
                }
            }

            var filePath = HostingEnvironment.ApplicationVirtualPath + "Files/База игроков.xlsx";
            FileInfo excelInfo = new FileInfo(Server.MapPath(filePath));

            if (excelInfo.Exists) excelInfo.Delete();

            ExcelPackage package = new ExcelPackage(excelInfo);

            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("База игроков");
            worksheet.Cells[1, 1].Value = "FullName";
            worksheet.Cells[1, 2].Value = "NickName";
            worksheet.Cells[1, 3].Value = "PlayerID";
            worksheet.Cells[1, 4].Value = "SignatureHero";
            worksheet.Cells[1, 5].Value = "WinRate";
            worksheet.Cells[1, 6].Value = "PrimaryRole";
            worksheet.Cells[1, 7].Value = "SoloRating";
            worksheet.Cells[1, 8].Value = "RateStars";

            int row = 2;
            int roleIndex = 0;
            for (int i = 0; i < player.Length; i++)
            {
                worksheet.Cells[row, 1].Value = player[i].FullName;
                worksheet.Cells[row, 2].Value = player[i].NickName;
                worksheet.Cells[row, 3].Value = player[i].PlayerID;
                worksheet.Cells[row, 4].Value = player[i].SignatureHero;
                worksheet.Cells[row, 5].Value = player[i].WinRate;
                worksheet.Cells[row, 6].Value = player[i].PrimaryRole;
                worksheet.Cells[row, 7].Value = player[i].SoloRating;
                worksheet.Cells[row, 8].Value = player[i].RateStars;
                int k = 0;
                for (int j = roleIndex; j < roleIndex + currenciesCount[i]; j++)//?
                {
                    worksheet.Cells[row + k, 6].Value = currencys[j].Role;
                    k++;
                }
                roleIndex += currenciesCount[i];
                if (currenciesCount[i] != 0)
                {
                    row += currenciesCount[i];
                }
                else row++;
            }

            package.Save();

            return File(filePath, "application/ooxml", "База игроков.xlsx");
        }
        private class EmptyDbException : Exception
        { }


    }

}