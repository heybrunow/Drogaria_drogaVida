using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using projeto_estoque_drogavida;

namespace projeto_estoque_drogavida.Controllers
{
    public class operadorsController : Controller
    {
        private db_drogavida_estoqueEntities db = new db_drogavida_estoqueEntities();

        // GET: operadors
        public ActionResult Index()
        {
            return View(db.operador.ToList());
        }

        // GET: operadors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operador operador = db.operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // GET: operadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: operadors/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome,cpf_o,email,senha,tel,endereco,data_de_nascimento")] operador operador)
        {
            if (ModelState.IsValid)
            {
                db.operador.Add(operador);
                db.SaveChanges();
                return RedirectToAction("Login","Home");
            }

            return View(operador);
        }

        // GET: operadors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operador operador = db.operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // POST: operadors/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nome,cpf_o,email,senha,tel,endereco,data_de_nascimento")] operador operador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operador);
        }

        // GET: operadors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            operador operador = db.operador.Find(id);
            if (operador == null)
            {
                return HttpNotFound();
            }
            return View(operador);
        }

        // POST: operadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            operador operador = db.operador.Find(id);
            db.operador.Remove(operador);
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
