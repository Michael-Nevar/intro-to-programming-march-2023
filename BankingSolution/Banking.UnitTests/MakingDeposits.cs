
using Banking.Domain;
using System.Diagnostics.CodeAnalysis;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Theory]
        [InlineData(100)]
        [InlineData(1.25)]
        public void DepositsIncreasesTheBalance(decimal amountToDeposit)
        {
            //given
            var account = new BankAccount();
            var openingBalancee = account.GetBalance(); // Query (Func)

            //when
            account.Deposit(amountToDeposit); // Command (Action)

            // then
            Assert.Equal(openingBalancee + amountToDeposit,
                account.GetBalance());
        }
    }
}
