using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NuevaController : Controller
    {
        // GET: Nueva
        public ActionResult NuevaVista()
        {
            ViewBag.Nombre = "RCA";
            return View();
        }
        public ActionResult Vista(string n1, string n2)
        {
            return View();
        }
        public ActionResult Calcular(OperasBas op)
        {
            op.Res = op.resultado();
            return View(op);
        }
       
        public ActionResult MostrarPulques()
        {
            var pulques = new ProductoServices();
            var model = pulques.ObtenerProducto();
            return View(model);
        }
        public ActionResult Calcular2(Puntos p)
        {
            p.Res = p.distancia();
            return View(p);
        }


    }


}
