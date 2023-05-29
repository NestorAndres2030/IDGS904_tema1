using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var pulque = new Producto()
            {

                nombre = "PULQUE",
                descripcion = "FRESA",
                cantidad = 10,
                produccion = new DateTime(2023,11,2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);


            //Se puede enviar puras vistas solo en el Action Result se cambia a ViewResult
           // return Content("<h1> Nestor Andres Peña <h1>");
            
            return View();
        }
        public  RedirectResult vista() 
        {
            return Redirect("https://google.com");
        }
        public RedirectToRouteResult vista1() {
            TempData["Nombre"] = "Nestor";
            return RedirectToAction("Index");
        }
        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";
            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.valor = nombre;

            return View();
        }
    }
}