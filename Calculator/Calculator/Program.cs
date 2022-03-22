using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calaculator");
            Console.WriteLine("-------------------");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.SubStract");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter your choice(1-4)");
            int ch = Int32.Parse(Console.ReadLine());
            int a, b, c;

            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Sum = {0}",c);
                    break;
                case 2:
                    Console.WriteLine("Enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Difference = {0}", c);

                    break;
                case 3:
                    Console.WriteLine("Enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Multiply = {0}", c);
                    break;
                case 4:
                    Console.WriteLine("Enter a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b");
                    b = Convert.ToInt32(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Division = {0}", c);
                    break ;
                default:
                    Console.WriteLine("Invalid Choice");
                    break ;
            }
            Console.ReadKey();










        }
    }
}
