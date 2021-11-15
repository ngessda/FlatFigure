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
        private double side_1;
        private double side_2;
        private double side_3;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Triangle()
        {
            side_1 = 0;
            side_2 = 0;
            side_3 = 0;
        }
        public Triangle(double a,double b,double c)
        {
            side_1 = a;
            side_2 = b;
            side_3 = c;
        }
        public override double Perimeter()
        {
            return (side_1 + side_2 + side_3);
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            double s = p * (p - side_1) * (p - side_2) * (p - side_3);
            return Math.Sqrt(s);
        }
    }
}
