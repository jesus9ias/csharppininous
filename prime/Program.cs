using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkForNum = true;

            while(checkForNum == true)
            {
                Console.Write("Write a number:\n");
                Int64 num = Int64.Parse(Console.ReadLine());
                int x = 2;
                double sqr = Math.Sqrt(num);
                bool isPrime = true;

                while (x <= sqr && isPrime == true)
                {
                    if (num % x == 0)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        x++;
                    }
                }

                if (isPrime == true)
                {
                    Console.Write("The number {0} is prime and it was solved in {1} steps\n", num, x);
                }
                else
                {
                    Console.Write("The number {0} is not prime and it was solved in {1} steps\n", num, x);
                }

                Console.Write("Do you want to check another number?, y for 'Yes', any else for 'No':\n");
                checkForNum = (Console.ReadLine() == "y");
            }
        }
    }
}
