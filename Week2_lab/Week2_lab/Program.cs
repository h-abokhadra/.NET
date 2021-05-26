using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter first integer: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is {num1 + num2}");

            System.Threading.Thread.Sleep(5 * 60 * 1000);


        }


    }
}
