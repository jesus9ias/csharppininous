using System;
using System.Threading;

namespace cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
                Thread.Sleep(500);
            }
        }
    }
}
