using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kursachtry;

namespace GoHome.Web.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Print(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var star = Serialization.LoadFromStream(file.InputStream);
                return View(star);
            }

            return RedirectToAction("Index");
        }
    }
}