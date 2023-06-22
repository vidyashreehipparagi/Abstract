using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle r1 = new Rectangle(10, 20);
            r1.CalculateArea();
            Console.WriteLine(r1);
        }
    }
}
