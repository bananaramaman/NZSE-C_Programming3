using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount("JohnDoe", currentBalance);

            // act
            account.Withdraw(withdrawal);

            // assert
            Assert.AreEqual(expected, account.Balance);
        }

        [TestMethod]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
            // arrange
            var account = new CheckingAccount("John Doe", 10.0);

            // act and assert
            Assert.ThrowsException<System.ArgumentException>(() => account.Withdraw(20.0));
        }
    }
}
