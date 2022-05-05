using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void BankAccountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MakeDepositTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Test_Withdrawl_ValidAmount_ChangesBalance()
        {
            // Arrange
            decimal currentBalance = 10.0m;
            decimal withdrawal = 1.0m;
            decimal expected = 9.0m;
            var account = new BankAccount("JohnDoe", currentBalance);
            // Act
            account.MakeWithdrawal(withdrawal, DateTime.Now, "Test withdrawl from the account");

            // Assert
            Assert.AreEqual(expected, account.Balance);
            //Assert.Fail();
        }
        //Doesn't support decimal 
        [DataTestMethod]
        [DataRow("10", "2", "8")]
        [DataRow("10.0", "2.5", "7.5")]
        //[DataRow(100, 100, 0)]
        //[DataRow(1020, 20, 1000)]
        //[DataRow(1020, -20, 1000)]
        public void Test_Withdrawl_ValidAmount_ChangesBalance2(string startingBalance, string withdrawalAmount, string expectedBalance)
        {
            // Arrange
            decimal currentBalance = Convert.ToDecimal(startingBalance);
            decimal withdrawal = Convert.ToDecimal(withdrawalAmount);
            decimal expected = Convert.ToDecimal(expectedBalance);
            var account = new BankAccount("JohnDoe", currentBalance);
            // Act
            account.MakeWithdrawal(withdrawal, DateTime.Now, "Test withdrawl from the account");

            // Assert
            Assert.AreEqual(expected, account.Balance);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Test_Withdraw_AmountMoreThanBalance_Throws()
        {
            // Arrange
            var account = new BankAccount("JohnDoe", 10.0m);

            // Act and Assert
            Assert.ThrowsException<System.ArgumentException>(() => account.MakeWithdrawal(20.0m, DateTime.Now, "Test withdrawl from the account"));
            // Assert
            
        }
    }
}