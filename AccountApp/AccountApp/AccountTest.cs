using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AccountApp
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            //create object
            Account Acct = new Account();

            string AccountName = Console.ReadLine();

            Acct.SetHolderName(AccountName);

            Console.WriteLine($"The account holder name is {Acct.GetHolderName()}");
            Thread.Sleep(10000);
        }
    }
}
