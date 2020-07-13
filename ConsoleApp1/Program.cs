using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, average;

            Console.Write("Enter 1st number :");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = Convert.ToInt16(Console.ReadLine());

            average = (number1 + number2 + number3) / 3;

            Console.Write("Average of three numbers is {0}", average);

            Console.ReadKey();
        }
    }
}
