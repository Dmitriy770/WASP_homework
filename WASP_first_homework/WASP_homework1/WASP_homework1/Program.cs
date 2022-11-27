using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WASP_homework1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("task 1.1");
            for (int a4 = 0; a4 < 10; a4++) {
                for(int a3 = a4+1; a3 < 10; a3++) 
                {
                    for(int a2 = a3+1; a2 < 10; a2++)
                    {
                        for(int a1 = a2+1; a1 < 10; a1++)
                        {
                            Console.WriteLine(a1*1000 + a2*100 + a3*10 + a4);
                        }
                    }
                }
            }

            Console.WriteLine("\ntask 1.2");
            int n = Convert.ToInt16(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write(n - Math.Abs(j - i));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\ntask 2.3");
            short x1 = short.Parse(Console.ReadLine());
            short x2 = short.Parse(Console.ReadLine());
            short x3 = short.Parse(Console.ReadLine());
            short x4 = short.Parse(Console.ReadLine());
            long res;
            res = ((long)x4 << 16 * 3) + ((long)x3 << 16*2) + ((long)x2 << 16) + x1;
            Console.WriteLine(res);

            Console.WriteLine("\ntask 2.4");
            res = long.Parse(Console.ReadLine());
            x1 = (short)(res);
            x2 = (short)(res >> 16);
            x3 = (short)(res >> 16*2);
            x4 = (short)(res >> 16*3);
            Console.WriteLine($"{x4} {x3} {x2} {x1}");
        }

    }
}