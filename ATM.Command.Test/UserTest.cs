using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATM.Command.Business;
namespace CommandPattern
{
    [TestClass]
    public class UserTest
    {

        [TestMethod]
        public void checkBalanceTest()
        {
            User user = new User("Li", 0);

            Assert.AreEqual(0, user.checkBalance());

            Assert.AreEqual(1000, user.deposit(1000));

            Assert.AreEqual(700, user.withDraw(300));

            Assert.AreEqual(500, user.charge(100));

        }

        //[TestMethod]
        //public void depositTest()
        //{
        //    User user = new User("Li", 0);

            
        //}

        //[TestMethod]
        //public void withDrawTest()
        //{
        //    User user = new User("Li", 0);
        //    user.deposit(1000);
        //    Assert.AreEqual(700, user.withDraw(300));
        //}

        //[TestMethod]
        //public void chargeTest()
        //{
        //    User user = new User("Li", 0);
        //    //user.deposit(1000);
        //    //user.withDraw(300);
        //    Assert.AreEqual(500, user.charge(100));
        //}

    }
}
