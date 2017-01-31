using System;
using System.Collections.Generic;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            bool isSettingNumbers = true;
            Console.WriteLine("Order numbers by bublesort");

            while (isSettingNumbers == true)
            {
                Console.WriteLine("set a number");
                string num = Console.ReadLine();
                if (num == null || num == "")
                {
                    isSettingNumbers = false;
                }
                else
                {
                    nums.Add(Int32.Parse(num));
                }
            }

            for (var i = 0; i < nums.Count; i++)
            {
                for (var j = 0; j < nums.Count; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int x = nums[j];
                        nums[j] = nums[i];
                        nums[i] = x;
                    }
                }
            }

            foreach (int z in nums)
            {
                Console.WriteLine(z);
            }

            Console.ReadLine();
        }
    }
}
