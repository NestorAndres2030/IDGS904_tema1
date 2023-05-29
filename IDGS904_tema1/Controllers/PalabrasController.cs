using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class PalabrasController : Controller
    {
        // GET: Palabras
        public ActionResult Palabras()
        {
            // Crea una instancia de LeerServices
            var arch = new LeerServices();

            // Lee las palabras y las asigna a la propiedad ViewBag.Archivo
            ViewBag.Archivo = arch.LeerPalabras();

            // Devuelve la vista "Palabras"
            return View();
        }

        public ActionResult Buscar()
        {
            // Devuelve la vista "Buscar"
            return View();
        }

        [HttpPost]
        public ActionResult BuscarPalabra(Palabras p)
        {
            // Llama al método BuscarTraduccion() del objeto p de tipo Palabras
            p.BuscarTraduccion();

            // Guarda el resultado en TempData para accederlo en la vista
            TempData["Result"] = p.Resultado + "";

            // Redirige a la acción "Buscar"
            return RedirectToAction("Buscar");
        }

        [HttpPost]
        public ActionResult Guardar(Palabras pal)
        {
            // Crea una instancia de GuardarServices
            var ope1 = new GuardarServices();

            // Guarda las palabras utilizando el objeto ope1 y el método GuardarPalabras()
            ope1.GuardarPalabras(pal);

            // Crea una instancia de LeerServices
            var arch = new LeerServices();

            // Lee las palabras actualizadas y las asigna a la propiedad ViewBag.Archivo
            ViewBag.Archivo = arch.LeerPalabras();

            // Redirige a la acción "Palabras"
            return RedirectToAction("Palabras");
        }
    }


}