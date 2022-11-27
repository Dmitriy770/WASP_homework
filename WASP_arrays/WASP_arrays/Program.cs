using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WASP_homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите массив:");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);

            Console.WriteLine("Введите k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"k-ый минимум: {min(nums, k)}");


            Console.WriteLine("Введите количество элементов массива:");
            Console.ReadLine();
            Console.WriteLine("Введите массив: ");
            int[] nums2 = Array.ConvertAll(Console.ReadLine().Split(" "), Convert.ToInt32);
            Console.WriteLine("Введите start, end, step:");
            int[] par = Array.ConvertAll(Console.ReadLine().Split(":"), Convert.ToInt32);
            smartPrint(nums2, par[0], par[1], par[2]);
        }

        public static int min(int[] nums, int k)
        {
            for(int i=0; i<k; i++)
            {
                for(int j=1; j<nums.Length; j++)
                {

                    if (nums[j-1] < nums[j])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j-1];
                        nums[j-1] = tmp;
                    }
                }
            }
            return nums[nums.Length - k];
        }

        public static void smartPrint(int[] nums, int a, int b, int step)
        {
            int st = a; int end = b;
            if(step < 0)
            {
                st = -b;
                end = -a;
                step = -step;
            }

            for(int i=st; i<end; i += step)
            {
                Console.Write(nums[Math.Abs(i)] + " ");
            }
        }

    }
}
