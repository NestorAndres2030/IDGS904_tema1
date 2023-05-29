using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var alumno =new Alumnos()
            { Nombre="Pedro",
              Edad=20      ,
              Activo=true   ,
              Inscrito=new DateTime(2023,1,1)
                    };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Registrar() {
            return View(); 
        }
        public ActionResult Temperatura(Grados temp)
        {
            temp.CalcularCelcius();
            TempData["Result"] = temp.Resultado + "";
          

            return View();
        }
    }
}