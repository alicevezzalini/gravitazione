using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravitazione
{
    internal class Forza : Vector
    {
        public Forza(double x, double y) : base(x, y) 
        {
          
        }

        public static double Gravitazionale(double m1, double m2, double r)
        {
            double G = 6.67 * Math.Pow(10, -11);
            return (G * m1 * m2) / (r * r);
        }
      
    }
}
