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
        private double d;
        public override string TypeOfFigure
        {
            get
            {
                return type;
            }
        }
        public Circle()
        {
            d = 0;
        }
        public Circle(double d1)
        {
            d = d1;
        }
        public override double Perimeter()
        {
            return d * Math.PI;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(d / 2, 2);
        }
    }
}
