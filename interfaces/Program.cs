using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    interface IOperations
    {
        decimal sum();
        decimal rest();
        decimal multi();
        decimal divide();
    }

    class Operations : IOperations
    {
        decimal x, y;

        public Operations(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal sum()
        {
            return x + y;
        }

        public decimal rest()
        {
            return x - y;
        }

        public decimal multi()
        {
            return x * y;
        }

        public decimal divide()
        {
            return x / y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which operation do yo want to do? (s, r, m, d): ");
            string op = Console.ReadLine();

            Console.Write("Set number one: ");
            decimal x = decimal.Parse(Console.ReadLine());

            Console.Write("Set number two: ");
            decimal y = decimal.Parse(Console.ReadLine());

            decimal res = 0;

            IOperations ops = new Operations(x, y);

            switch (op)
            {
                case "s":
                    res = ops.sum();
                    break;
                case "r":
                    res = ops.rest();
                    break;
                case "m":
                    res = ops.multi();
                    break;
                case "d":
                    res = ops.divide();
                    break;
            }

            Console.Write("The result is: {0}", res);

            Console.ReadLine();

        }
    }
}
