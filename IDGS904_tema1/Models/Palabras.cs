using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing.Drawing2D;


namespace IDGS904_tema1.Models
{
    public class Palabras
    {
        public string Ingles { get; set; }
        public string espanol { get; set; }

        public string Palabra { get; set; }

        public string Select { get; set; }
        public string Resultado { get; set; }
        public class PalabrasModel
        {
            public string[] Datos { get; set; }
        }

        public Palabras() { 
            this.Palabra = "";
        }

        public void BuscarTraduccion()
        {
            // Obtiene la ruta del archivo de palabras
            var archivoPalabras = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");

            // Variable para indicar si se encontró la traducción
            bool encontrada = false;

            // Convierte la palabra a buscar a mayúsculas
            var pal = Palabra.ToUpper();

            // Verifica si el archivo de palabras existe
            if (File.Exists(archivoPalabras))
            {
                // Lee todas las líneas del archivo
                var lineas = File.ReadAllLines(archivoPalabras);

                // Recorre cada línea
                foreach (var linea in lineas)
                {
                    // Divide la línea en las palabras separadas por coma
                    string[] palabras = linea.Split(',');

                    // Verifica si la selección es "ingles" y la palabra en la posición 1 coincide
                    if (this.Select == "ingles" && palabras.Length >= 2 && palabras[1].Trim().Equals(pal, StringComparison.OrdinalIgnoreCase))
                    {
                        // Asigna la traducción encontrada a la propiedad Resultado
                        this.Resultado = palabras[0].Trim();

                        // Marca que se encontró la traducción
                        encontrada = true;

                        // Sale del bucle, ya que se encontró la traducción
                        break;
                    }
                    // Verifica si la selección es "espanol" y la palabra en la posición 0 coincide
                    else if (this.Select == "espanol" && palabras.Length >= 2 && palabras[0].Trim().Equals(pal, StringComparison.OrdinalIgnoreCase))
                    {
                        // Asigna la traducción encontrada a la propiedad Resultado
                        this.Resultado = palabras[1].Trim();

                        // Marca que se encontró la traducción
                        encontrada = true;

                        // Sale del bucle, ya que se encontró la traducción
                        break;
                    }
                }

                // Si no se encontró ninguna traducción
                if (!encontrada)
                {
                    this.Resultado = "No existe ninguna traducción";
                }
            }
        }




    }

}