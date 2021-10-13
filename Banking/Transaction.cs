using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Transaction
    {
        // Properties
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes
        {
            get;

        }

        // Constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
