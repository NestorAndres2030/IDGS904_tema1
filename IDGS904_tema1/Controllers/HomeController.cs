using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NuevoControlador()
        {
            ViewBag.Message = "Hola Controlador";
            return View();
        }
        public ActionResult Saludo()
        {
            ViewBag.Message = "Hola Mundo";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Materia = "Desarrollo Web Integral";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}