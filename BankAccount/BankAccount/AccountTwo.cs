using System;

namespace BankAccount
{
    public enum AccountStatusTwo
    {
        Open,
        Closed
    }
    class AccountTwo
    {
        public AccountStatusTwo StatusTwo { get; }
        public string OwnerTwo { get; set; }
        public decimal BalanceTwo { get; set; }
        public AccountTwo(string ownerTwo, decimal balanceTwo)
        {
            OwnerTwo = ownerTwo;
            BalanceTwo = balanceTwo;
            StatusTwo = AccountStatusTwo.Closed; 
        }
       
        public void DepositTwo(decimal amountTwo)
        {
            if (StatusTwo == AccountStatusTwo.Closed)
            {
                Console.WriteLine("Your account is closed, no transactions allowed.");
                return;
            }
            
            BalanceTwo += amountTwo;
        }
        public void WithdrawalTwo(decimal withdrawlAmountTwo)
        {
            if (StatusTwo == AccountStatusTwo.Closed)
            {
                Console.WriteLine("Your account is closed, no transactions allowed.");
                return;
                
            }
            BalanceTwo += withdrawlAmountTwo;
        }
    }
}
