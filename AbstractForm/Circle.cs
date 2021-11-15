using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    class Circle:FlatFigure
    {
        private const string type = "Круг";
        private double diameter;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Circle()
        {
            diameter = 0;
        }
        public Circle(double d)
        {
            diameter = d;
        }
        public override double Perimeter()
        {
            return diameter * Math.PI;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(diameter / 2, 2);
        }
    }
}
