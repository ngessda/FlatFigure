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
        private double a;
        private double b;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Rectangle()
        {
            a = 0;
            b = 0;
        }
        public Rectangle(double a1, double b1)
        {
            a = a1;
            b = b1;
        }
        public override double Perimeter()
        {
            return (a + b) * 2;
        }
        public override double Area()
        {
            return a * b;
        }
    }
}
