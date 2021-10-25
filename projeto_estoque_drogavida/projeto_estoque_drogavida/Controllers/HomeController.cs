using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projeto_estoque_drogavida.Controllers
{
    public class HomeController : Controller
    {
        private db_drogavida_estoqueEntities db = new db_drogavida_estoqueEntities();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(operador u)
        {
                {
                    var v = db.operador.Where(a => a.cpf_o.Equals(u.cpf_o) && a.senha.Equals(u.senha)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["usuarioLogadoID"] = v.cpf_o.ToString();
                        Session["nomeUsuarioLogado"] = v.nome.ToString();
                        return RedirectToAction("Index");
                    }
                }
            
            return View(u);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}