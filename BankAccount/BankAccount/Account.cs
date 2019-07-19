using System;

namespace BankAccount
{
    public enum AccountStatus
    {
        Open,
        Closed
    }
   
    public class Account
    {

        public AccountStatus StatusOwner { get; set; }
        public AccountStatus StatusNonExisting { get; set; }
        public string Owner { get; set; }
        public string NonExistingClient { get; set; }
        public decimal Balance { get; set; }
       
        public Account (string owner, string nonExistent, decimal balance)
        {
            Owner = owner;
            Balance = balance;
            NonExistingClient = nonExistent;
            //NonExistingClient = AccountStatus.Closed.ToString();
            this.StatusOwner = AccountStatus.Open;
            this.StatusNonExisting = AccountStatus.Closed;
        }
      
        public void DepositNonExisting(AccountStatus status)
        {
            
            if (StatusNonExisting == AccountStatus.Closed)
            {
                Console.WriteLine("The account is closed. Your transaction is denied");
                return;
            }
            
        }
        public void DepositOwner(decimal amount)
        {
            if (StatusOwner == AccountStatus.Open)
            {
                Balance += amount;
                Console.WriteLine($"The amount of {amount} $ has been alocated to your account.");
                return;
            }
        }
       public void WithdrawalNonExisting(AccountStatus statusB)
       {
            if (StatusNonExisting == AccountStatus.Closed)
            {
                Console.WriteLine("The account is closed. Your transaction is denied");
                return;
            }
        }
       
        public void Withdrawal(decimal withdrawalAmount)
        {
           
            if (StatusOwner == AccountStatus.Open && Balance > withdrawalAmount)
            {
                Balance -= withdrawalAmount;
                Console.WriteLine($"The amount {withdrawalAmount} has been withdrawn from your account.");
                return;
            }
            if (StatusOwner == AccountStatus.Open && Balance < withdrawalAmount)
            {
                Balance -= withdrawalAmount;

                Console.WriteLine($"Insufficient funds.You tried to withdraw {withdrawalAmount} from current {Balance}");
                return;
            }
            else /*if (withdrawalAmount > 1000)*/
            {
                Balance -= withdrawalAmount;

                Console.WriteLine("Withdrawal limit exceeded");
                return;
            }
        }

    }
}
