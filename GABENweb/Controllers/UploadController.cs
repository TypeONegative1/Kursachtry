using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary;
using GABENweb.Models;

namespace GABENweb.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Print(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var player = Serialization.LoadFromStream(file.InputStream);

                using (var db = new ApplicationDbContext())
                {
                    var row = new DbPlayer
                    {
                        FullName = player.FullName,
                        NickName = player.NickName,
                        PlayerID = player.PlayerID,
                        SignatureHero = player.SignatureHero,
                        WinRate = player.WinRate,
                        PrimaryRole = new Collection<DbCurrency>(),
                        SoloRating = player.SoloRating,
                        RateStars = player.RateStars,
                    };
                    foreach (var elem in player.PrimaryRole)
                    {
                        row.PrimaryRole.Add(new DbCurrency
                        {
                            Role = elem,
                        });
                    }

                    db.DbPlayers.Add(row);
                    db.SaveChanges();
                }
                return View(player);
            }

            return RedirectToAction("Index");
        }
    }
}