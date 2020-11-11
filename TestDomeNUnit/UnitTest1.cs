using NUnit.Framework;
using TestDomePractice;

namespace TestDomeNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class AccountTests
    {	
        private double epsilon = 1e-6;

        [Test]
        public void AccountCannotHaveNegativeOverdraftLimit()
        {
            Account account = new Account(-20);
        
            Assert.AreEqual(0, account.OverdraftLimit, epsilon);
        }
    
        [Test]
        public void DepositWontAcceptNegative()
        {
            Account account = new Account(-20);
        
            Assert.AreEqual(false, account.Deposit(-5.0));
        }
        [Test]
        public void WithdrawWontAcceptNegative()
        {
            Account account = new Account(-20);
        
            Assert.AreEqual(false, account.Withdraw(-5.0));
        }
    
        [Test]
        public void CannotOverstepOverdraft()
        {
            Account account = new Account(-20);
            Assert.AreEqual(false, account.Withdraw(25.0));
        }
    
        [Test]
        public void WithdrawCorrectAmount()
        {
            Account account = new Account(-20);
            account.Deposit(20);
            Assert.AreEqual(true, account.Withdraw(5.0));
        }
    
        [Test]
        public void DepositCorrectAmount()
        {
            Account account = new Account(-20);
       
            Assert.AreEqual(true, account.Deposit(10.0));
        }

    }
}