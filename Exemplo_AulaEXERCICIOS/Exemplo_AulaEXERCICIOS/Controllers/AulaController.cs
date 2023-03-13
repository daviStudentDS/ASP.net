
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo_AulaEXERCICIOS.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aluno()
        {
            ViewBag.Primeira = "Aluno";
            ViewData["Pri"] = "Os melhores alunos são aqueles que estudam mais.";
            return View();
        }
        public ActionResult Teste()
        {
            TempData["Exemplo3"] = "";
            return RedirectToAction("Aluno");
        }

        public ActionResult Resultado()
        {
            if (TempData["Exemplo3"] != null)
                ViewBag.Exemplo2 = "Os melhores alunos são aqueles que estudam mais.";
            return View();



        }
        public ActionResult Google()
        { 
            return Redirect("https://google.com");
        }

    }
}