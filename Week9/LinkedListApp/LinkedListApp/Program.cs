using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> EmpName = new LinkedList<string>();


             //Mark Sarah Omar Paul Jeny

            EmpName.AddFirst("Sarah");
            EmpName.AddLast("Paul");
            EmpName.AddFirst("Mark");

            //Var that holds the found node
            LinkedListNode<string> FoundNode= EmpName.Find("Paul");

            //Add a node before paul's node
            EmpName.AddBefore(FoundNode, "Omar");

            //Add a node after paul's node
            EmpName.AddAfter(FoundNode, "Jeny");


            foreach (string name in EmpName)
            {
                Console.WriteLine($"The employee name is: {name}");
                Thread.Sleep(1000);
            }

            Thread.Sleep(10000);
        }
    }
}
