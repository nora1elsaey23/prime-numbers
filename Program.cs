using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2");
            int n2 = int.Parse(Console.ReadLine());
            int count;
            for (int i = n1; i <= n2; i++)
            {             count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine($"{i}Prime");

            }
        }



















    }
}


