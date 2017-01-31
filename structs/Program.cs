using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    class Program
    {
        public struct Coordis
        {
            public int x, y;

            public Coordis(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        static void Main(string[] args)
        {
            Coordis coords = new Coordis(2, 5);
            Console.Write("x = {0}, y = {1}", coords.x, coords.y);

            Console.ReadLine();
        }
    }
}
