using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double lato = 400 * Math.Pow(10, 6);
            double diagonale = Math.Sqrt(lato * lato + lato * lato);
            double m1 = 6 * Math.Pow(10, 24);
            double m2 = 7 * Math.Pow(10, 22);
            double m3 = m2;
            double m4 = m3;

            double f12 = Forza.Gravitazionale(m1, m2, lato);
            double f13 = Forza.Gravitazionale(m1, m3, diagonale);
            double f14 = Forza.Gravitazionale(m1, m4, lato);

            double f13x = f13 * Math.Cos(Math.PI/4);
            double f13y = f13 * Math.Sin(Math.PI/4);

            double rx = f12 + f13x;
            double ry = f14 + f13y;

            double r = Math.Sqrt(ry * ry + rx * rx);

            Console.WriteLine(r);
            Console.ReadLine();
            
        }

       
    }
}
