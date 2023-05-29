using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class PuntosController : Controller
    {
        // GET: Puntos
        public ActionResult Index(Puntos p)
        {
            p.Res = p.distancia();
            return View(p);
        }
        public ActionResult Resultado(Puntos p)
        {
            p.Res = p.distancia();
            return View(p);
        }


    }
}