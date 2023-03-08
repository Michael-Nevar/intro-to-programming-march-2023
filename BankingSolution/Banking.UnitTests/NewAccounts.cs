
using Banking.Domain;

namespace Banking.UnitTests
{
    public class NewAccounts
    {
        [Fact]
        public void NewAccountHasCorrectOpeningBalance()
        {
            // "Write the Code You Wish You Had" (WTCYWYH)
            // Given
            BankAccount account = new BankAccount();
            // When
            decimal balance = account.GetBalance();
            //then
            Assert.Equal(5000, balance);
        }
    }
}
