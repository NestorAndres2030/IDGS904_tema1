using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult CalcularTriangulos(Triangulos t)
        {
            t.CalcularTipoTriangulo();

            return View(t);
        }
    }

}