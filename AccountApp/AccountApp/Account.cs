using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp{
    class Account{
       private string AccountHolderName;
       private double AccountBalance;


       public void SetHolderName(string name){

            AccountHolderName = name;
        }

        public string GetHolderName(){

            return AccountHolderName;
        }
        public void SetAccountBalance(double balance)
        {

            AccountBalance = balance;
        }

        public double GetAccountBalance()
        {

            return AccountBalance;
        }

    }
}
