using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarServices
    {
        public void  GuardarArchivo(Maestros maes) {

            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var edad=maes.Edad;
            var email = maes.Email;
            var datos = nombre + ","+apaterno+","+amaterno+","+edad+","+
                email+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
           // File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }
        public void GuardarPalabras(Palabras pal)
        {

            var ingles = pal.Ingles.ToUpper();
            var espanol = pal.espanol.ToUpper();
            
            var datos = ingles + "," + espanol + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            // File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);
        }
    }
}