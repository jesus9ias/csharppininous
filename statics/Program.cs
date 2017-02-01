using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statics
{
    class ops
    {
        public static double sum(double x, double y)
        {
            return x + y;
        }

        public static double rest(double x, double y)
        {
            return x - y;
        }

        public static double multi(double x, double y)
        {
            return x * y;
        }

        public static double divide(double x, double y)
        {
            return x / y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ops.sum(3, 4) + "\n");
            Console.Write(ops.rest(5, 9.2) + "\n");
            Console.Write(ops.multi(10, 4) + "\n");
            Console.Write(ops.divide(100, 3) + "\n");

            Console.ReadLine();
        }
    }
}
