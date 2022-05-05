﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankAccount
    {
        // Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get

            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }

        }
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        // Constructor
        public BankAccount(string name, decimal initialBalance)
        {
            var deposit= new Transaction(initialBalance, DateTime.Now, "Initial opening balance");
            allTransactions.Add(deposit);
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        // Functions
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(amount > this.Balance)
            {
                throw new ArgumentException("The withdrawal amount can not exceed the balance");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}
