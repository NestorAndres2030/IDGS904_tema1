using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace IDGS904_tema1.Models
{

    public class Triangulos
    {
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double x3 { get; set; }
        public double y3 { get; set; }
        public string resultado { get; set; }
        public double area { get; set; }

        public void CalcularTipoTriangulo()
        {
            double lado1 = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)),2);
            double lado2 = Math.Round(Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)),2);
            double lado3 = Math.Round(Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2)),2);

            if (EsTrianguloValido(lado1, lado2, lado3))
            {
                area = CalcularAreaTriangulo(x1, y1, x2, y2, x3, y3 );

                if (EsTrianguloEquilatero(lado1, lado2, lado3))
                {
                    resultado = "Triángulo Equilátero";
                }
                else if (EsTrianguloIsosceles(lado1, lado2, lado3))
                {
                    resultado = "Triángulo Isósceles";
                }
                else
                {
                    resultado = "Triángulo Escaleno";
                }
            }
            else
            {
                resultado = "No es un triángulo válido";
                area = 0;
            }
        }

        public bool EsTrianguloValido(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2;
        }

        public bool EsTrianguloEquilatero(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 && lado2 == lado3;
        }

        public bool EsTrianguloIsosceles(double lado1, double lado2, double lado3)
        {
            return lado1 == lado2 || lado2 == lado3 || lado1 == lado3;
        }

        public double CalcularAreaTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);
            return area;
        }


    }
    }
