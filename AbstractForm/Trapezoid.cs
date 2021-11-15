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
        private double side_1;
        private double side_2;
        private double side_3;
        private double side_4;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Trapezoid()
        {
            side_1 = 0;
            side_2 = 0;
            side_3 = 0;
            side_4 = 0;
        }
        public Trapezoid(double a, double b, double c, double d)
        {
            side_1 = a;
            side_2 = b;
            side_3 = c;
            side_4 = d;

        }
        public override double Perimeter()
        {
            return side_1 + side_2 + side_3 + side_4;
        }
        public override double Area()
        {
            double result_1 = (side_1 + side_2) / 2;
            double result_2 = (Math.Pow(side_1 - side_2, 2) + Math.Pow(side_3, 2) - Math.Pow(side_4, 2)) / (2 * (side_1 - side_2));
            double result_3 = Math.Pow(side_3, 2) - Math.Pow(result_2, 2);
            return result_1 * Math.Sqrt(result_3);
        }
    }
}
