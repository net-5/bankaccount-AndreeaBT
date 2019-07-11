using System;

namespace BankAccount
{
    public enum AccountStatusOne
    {
        Open,
        Closed
    }
    class Account
    {

        public AccountStatusOne StatusOne { get; set; }
        public string OwnerOne { get; set; }
        public decimal BalanceOne { get; set; }
       
        public Account (string ownerOne, decimal balanceOne)
        {
            OwnerOne = ownerOne;
            BalanceOne = balanceOne;
            StatusOne = AccountStatusOne.Open;
        }
      
        public void Deposit(decimal amount)
        {
            if (StatusOne == AccountStatusOne.Closed)
            {
                Console.WriteLine($"Your transaction is denied");
                return;
            }
            else if (StatusOne == AccountStatusOne.Open)
            {
                BalanceOne += amount;
                Console.WriteLine($"The amount of {amount} $ has been alocated to your account.");
                return;
            }
        }
        public void WithdrawalOne(decimal withdrawalAmountOne)
        {
            if(StatusOne == AccountStatusOne.Closed)
            {
                Console.WriteLine("Your transaction is denied");
                return;
            }
            else if (StatusOne == AccountStatusOne.Open && BalanceOne > withdrawalAmountOne)
            {
                BalanceOne -= withdrawalAmountOne;
                Console.WriteLine($"The amount {withdrawalAmountOne} has been withdrawn from your account.");
                return;
            }
            else if (BalanceOne < withdrawalAmountOne)
            {
                BalanceOne -= withdrawalAmountOne;

                Console.WriteLine($"Insufficient funds.You tried to withdraw {withdrawalAmountOne} from current {BalanceOne}");
                return;
            }
            else if (withdrawalAmountOne > 1000)
            {
                BalanceOne -= withdrawalAmountOne;

                Console.WriteLine("Withdrawal limit exceeded");
                return;
            }
        }

    }
}
