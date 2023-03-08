
using Banking.Domain;
using System.Security.Cryptography;

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Fact]
        public void MakingAWithdrawalDecreasesBalance()
        {
            //given
            var account = new BankAccount();
            var openingBalancee = account.GetBalance(); // Query (Func)
            var amountToWithdraw = 1M;

            //when
            account.Withdraw(amountToWithdraw); // Command (Action)

            // then
            Assert.Equal(openingBalancee - amountToWithdraw,
                account.GetBalance());
        }
    }
}
