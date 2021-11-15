using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    class Triangle: FlatFigure
    {

        private const string type = "Треугольник";
        private double a;
        private double b;
        private double c;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }
        public Triangle(double a1,double b1,double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public override double Perimeter()
        {
            return (a + b + c);
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            double s = p * (p - a) * (p - b) * (p - c);
            return Math.Sqrt(s);
        }
    }
}
