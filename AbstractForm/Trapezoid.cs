using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    class Trapezoid : FlatFigure
    {
        private const string type = "Трапеция";
        private double a;
        private double b;
        private double c;
        private double d;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Trapezoid()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }
        public Trapezoid(double a1, double b1, double c1, double d1)
        {
            a = a1;
            b = b1;
            c = c1;
            d = d1;

        }
        public override double Perimeter()
        {
            return a + b + c + d;
        }
        public override double Area()
        {
            double d = (a + b) / 2;
            double z = (Math.Pow(a - b, 2) + Math.Pow(c, 2) - Math.Pow(d, 2)) / (2 * (a - b));
            double x = Math.Pow(c, 2) - Math.Pow(z, 2);
            return d * Math.Sqrt(x);
        }
    }
}
