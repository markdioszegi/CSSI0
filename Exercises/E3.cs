using System;

namespace Exercises
{
    class E3
    {
        public E3()
        {
            int[] nums = new int[3];

            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.Write("Triangle side {0}: ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            if ((nums[0] > nums[1]) && (nums[0] > nums[2]) && (nums[1] > nums[2]))
            {
                System.Console.WriteLine("Triangle is editable.");
            }
            else
            {
                System.Console.WriteLine("Triangle is NOT editable.");
            }
        }
    }
}