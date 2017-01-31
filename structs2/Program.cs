using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs2
{
    class Program
    {
        public struct square
        {
            public int x, y;
            public square(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
        }

        static bool isRectangle(square sq)
        {
            return (sq.x != sq.y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Set lengt of X:\n");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Set lengt of Y:\n");
            int y = Int32.Parse(Console.ReadLine());

            square sq = new square(x, y);

            if (isRectangle(sq))
            {
                Console.WriteLine("This is a Rectangle");
            }else
            {
                Console.WriteLine("This is not a Rectangle");
            }

            Console.ReadLine();
        }
    }
}
