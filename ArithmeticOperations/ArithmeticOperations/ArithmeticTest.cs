using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    class ArithmeticTest
    {

        private double number1;
        private double number2;


        public void Setnum1(double num1)
        {

            double number1 = num1;
        }

        public double Getnum1()
        {

            return number1;
        }
        public void Setnum2(double num2)
        {

            double number2 = num2;
        }

        public double Getnum2()
        {

            return number2;
        }

        public double sum(double number1, double number2)
        {

            return number1 + number2;
        }

        public double multiplcation(double number1, double number2)
        {

            return number1 * number2;
        }

    }
}

