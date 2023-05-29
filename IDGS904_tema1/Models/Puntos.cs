using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Puntos
    {
        public Double x1 { get; set; }
        public Double y1 { get; set; }
        public Double x2 { get; set; }
        public Double y2 { get; set; }
        public String calcular { get; set; }
        public Double Res { get; set; }

        public Double distancia()
        {
            Double dx = x2 - x1;
            Double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}