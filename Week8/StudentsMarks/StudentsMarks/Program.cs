using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StudentsMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0, count = 0, Acount = 0, Bcount = 0, Ccount = 0, Dcount = 0, Fcount = 0;

            Console.WriteLine("Enter a mark or ^Z to stop");
            string input = Console.ReadLine();
            
            while (input!= null)
            {
                int grade = int.Parse(input);
                total += grade;
                count++;
                
                switch (grade/10)
                {
                    case 9:
                    case 10:
                        Acount++;
                        break;
                    case 8:
                        Bcount++;
                        break;
                    case 7:
                        Ccount++;
                        break;
                    case 6:
                        Dcount++;
                        break;
                    default:
                        Fcount++;
                        break;
                }//end of Switch statement 

                input = Console.ReadLine();

            }//end of loop

            if (count !=0)
            {
                Console.WriteLine($"The class AVG is : {total / count}");
            }

            Console.WriteLine($"Number of students in A class is : {Acount}");
            Console.WriteLine($"Number of students in B class is : {Bcount}");
            Console.WriteLine($"Number of students in C class is : {Ccount}");
            Console.WriteLine($"Number of students in D class is : {Dcount}");
            Console.WriteLine($"Number of students in F class is : {Fcount}");
            Thread.Sleep(20000);
        }
    }
}
