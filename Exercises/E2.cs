using System;

namespace Exercises
{
    public class E2
    {
        public E2()
        {
            int[] nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.Write("Number {0}: ", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            sortDescending(nums);

            byte c = 0;
            foreach (var num in nums)
            {
                if (c != nums.Length - 1)
                {
                    System.Console.Write(num + ", ");
                }
                else
                {
                    System.Console.Write(num);
                }
                c++;
            }
        }

        public void sortDescending(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        nums[i] = nums[i] ^ nums[j];
                        nums[j] = nums[i] ^ nums[j];
                        nums[i] = nums[i] ^ nums[j];
                    }
                }
            }
        }
    }
}