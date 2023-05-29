using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Grados
    {
        public double Grado { get; set; }
        public string Seleccionar { get; set; }
        public double Resultado { get; set; }

        public void CalcularCelcius()
        {
            if (this.Seleccionar == "Celsius")
            {
                this.Resultado = (this.Grado - 32) / 1.8;
            }
            else
            {
                this.Resultado = (this.Grado * 1.8) + 32;
            }
        }
    }
}