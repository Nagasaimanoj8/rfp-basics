using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    sum = sum + i;
                    Console.Write(" +" + sum);
                }
            }
            Console.WriteLine("");
            if (num == sum)
            {
                Console.WriteLine("the number is perfect number: " + num);
            }
        }
    }
}
