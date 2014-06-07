using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Comp2614Assignment4
{
  

    [TestFixture]
    public class BankAccountTest
    {
        [Test]
        public void TransferFunds()
        {
            BankAccount source = new SavingsAccount(200m);
            source.Deposit(200m);

            //Account destination = new Account();
            //destination.Deposit(150m);

            //source.TransferFunds(destination, 100m);

      //      Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }
    }
}