

namespace Banking.Domain;

// inheritance creates "Is a Kind Of" relationship
public class GoldBankAccount : BankAccount
{
    public override void Deposit(decimal amountToDeposit)
    {
        base.Deposit(amountToDeposit *1.10M);
    }
}
