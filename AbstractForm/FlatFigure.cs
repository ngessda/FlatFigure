using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    abstract class FlatFigure
    {
        public abstract string TypeOfFigure { get; }
        public abstract double Perimeter();
        public abstract double Area();
    }
}
