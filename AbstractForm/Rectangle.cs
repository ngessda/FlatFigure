using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    class Rectangle : FlatFigure
    {
        private const string type = "Прямоугольник";
        private double side_1;
        private double side_2;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Rectangle()
        {
            side_1 = 0;
            side_2 = 0;
        }
        public Rectangle(double a, double b)
        {
            side_1 = a;
            side_1 = b;
        }
        public override double Perimeter()
        {
            return (side_1 + side_2) * 2;
        }
        public override double Area()
        {
            return side_1 * side_2;
        }
    }
}
