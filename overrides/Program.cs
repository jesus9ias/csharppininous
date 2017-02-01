using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrides
{
    class shape
    {
        public virtual decimal Area(decimal x, decimal y)
        {
            return x * y;
        }
    }

    class triangle: shape
    {
        public override decimal Area(decimal x, decimal y)
        {
            return base.Area(x, y) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            shape rectangle1 = new shape();
            Console.Write(rectangle1.Area(3,5));

            Console.Write("\n");

            triangle triangle1 = new triangle();
            Console.Write(triangle1.Area(3, 5));

            Console.ReadLine();
        }
    }
}
