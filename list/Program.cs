using System;
using System.Linq;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var limit = 3;
            int[] source = { 0, 1, 1, 3, 2, 3, 4, 5 };
            var query = from item in source where item <= limit select item;
            foreach(int i in query)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
