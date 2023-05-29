using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public Double Num1 { get; set; }
        public Double Num2 { get; set; }
        public String calcular { get; set; }
        public Double Res { get; set; }

        public Double suma() { return (Num1 + Num2); }
        public Double resta() { return (Num1 - Num2); }
        public Double multi() { return (Num1 * Num2); }
        public Double divic() { return (Num1 / Num2); }

        public Double resultado() {
            
            double r = 0;
            switch (this.calcular)
            {
                case "suma":
                    r = suma();
                    break;
                case "resta":
                    r = resta();
                    break;
                case "multi":
                    r = multi();
                    break;
                case "divic":
                   r  = divic();
                    break;
    
            }
            return r;
        }



    }
   
}