using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {

            // Testing Code

            var account = new BankAccount("Milo", 1000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} dollars");

            decimal depositAmount = 200.0m;
            account.MakeDeposit(depositAmount, DateTime.Now, "Cash deposit made in person");

            Console.WriteLine($"Deposit of {depositAmount } euros made to Account {account.Number}. New balance of {account.Balance} euros");


        }
    }
}
