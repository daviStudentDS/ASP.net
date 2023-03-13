using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo_AulaEXERCICIOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            TempData["Exemplo3"] = "O MVC é um padrão muito utilizado no mundo web é conhecido por 'forçar' o programador a separar suas responsabilidades.";

            return View();
        }
        
    }
}