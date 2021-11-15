using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractForm
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatFigure sp = new Triangle(3, 2.3, 1);
            Console.Write("Фигура: ");
            Console.WriteLine(sp.TypeOfFigure);
            Console.Write("Периметр: ");
            Console.WriteLine(sp.Perimeter());
            Console.Write("Площадь: ");
            Console.WriteLine(sp.Area());

            Console.WriteLine("------------------------------------------------------------------------------------");

            FlatFigure wp = new Rectangle(4, 6);
            Console.Write("Фигура: ");
            Console.WriteLine(wp.TypeOfFigure);
            Console.Write("Периметр: ");
            Console.WriteLine(wp.Perimeter());
            Console.Write("Площадь: ");
            Console.WriteLine(wp.Area());

            Console.WriteLine("------------------------------------------------------------------------------------");

            FlatFigure zp = new Trapezoid(5, 1, 6, 8);
            Console.Write("Фигура: ");
            Console.WriteLine(zp.TypeOfFigure);
            Console.Write("Периметр: ");
            Console.WriteLine(zp.Perimeter());
            Console.Write("Площадь: ");
            Console.WriteLine(zp.Area());

            Console.WriteLine("------------------------------------------------------------------------------------");

            FlatFigure xp = new Circle(10);
            Console.Write("Фигура: ");
            Console.WriteLine(xp.TypeOfFigure);
            Console.Write("Периметр: ");
            Console.WriteLine(xp.Perimeter());
            Console.Write("Площадь: ");
            Console.WriteLine(xp.Area());

            Console.ReadKey();
        }
    }
}
