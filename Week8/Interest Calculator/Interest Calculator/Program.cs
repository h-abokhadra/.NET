using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1000;//princaple
            double r = 0.05;//Rate

            for (int n=1;n<=10;n++)
            {
                double a = p * (Math.Pow(1 + r, n));//Calculate the total after adding the intersest rate

                Console.WriteLine(a);
                Thread.Sleep(1000);
            }
            Thread.Sleep(6000);
        }
    }
}
