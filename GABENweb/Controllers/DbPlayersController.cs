using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GABENweb.Models;

namespace GABENweb.Controllers
{
    public class DbPlayersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DbPlayers
        public ActionResult Index()
        {
            return View(db.DbPlayers.ToList());
        }

        // GET: DbPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbPlayer dbPlayer = db.DbPlayers.Find(id);
            if (dbPlayer == null)
            {
                return HttpNotFound();
            }
            return View(dbPlayer);
        }

        // GET: DbPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DbPlayers/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,NickName,PlayerID,SignatureHero,WinRate,SoloRating,RateStars")] DbPlayer dbPlayer)
        {
            if (ModelState.IsValid)
            {
                db.DbPlayers.Add(dbPlayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbPlayer);
        }

        // GET: DbPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbPlayer dbPlayer = db.DbPlayers.Find(id);
            if (dbPlayer == null)
            {
                return HttpNotFound();
            }
            return View(dbPlayer);
        }

        // POST: DbPlayers/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,NickName,PlayerID,SignatureHero,WinRate,SoloRating,RateStars")] DbPlayer dbPlayer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbPlayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbPlayer);
        }

        // GET: DbPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DbPlayer dbPlayer = db.DbPlayers.Find(id);
            if (dbPlayer == null)
            {
                return HttpNotFound();
            }
            return View(dbPlayer);
        }

        // POST: DbPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DbPlayer dbPlayer = db.DbPlayers.Find(id);
            if (dbPlayer.PrimaryRole.Count > 0)
            {
                var firstRoleId = dbPlayer.PrimaryRole[0].Id;
                for (int i = firstRoleId; i <= firstRoleId + dbPlayer.PrimaryRole.Count; i++)
                {
                    var role = db.DbCurrencies.Find(i);
                    db.DbCurrencies.Remove(role);
                }
            }

            db.DbPlayers.Remove(dbPlayer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
