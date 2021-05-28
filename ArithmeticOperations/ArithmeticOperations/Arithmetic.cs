using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ArithmeticOperations
{
    class Arithmetic
    {
        static void Main(string[] args)
        {
            //create object
            ArithmeticTest process = new ArithmeticTest();


            Console.WriteLine("Enter the 1st number");

            double num1 = Console.Read();


            process.Setnum1(num1);

            Console.WriteLine("Enter the 2nd number");

            double num2 = Console.Read();

            process.Setnum2(num2);


            Console.WriteLine("The multiplcation result is ", process.multiplcation(num1, num2), "The sum result is ", process.sum(num1, num2)) ;
            Thread.Sleep(10000);

        }
    }
}
