using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int perNum = int.Parse(Console.ReadLine());
            int rev = 0;
            while (perNum > 0)
            {
                int rem = perNum % 10;
                rev = (rev * 10) + rem;
                perNum = perNum / 10;
            }
            Console.WriteLine("reverse number is:" + rev);
        }
    }
}
