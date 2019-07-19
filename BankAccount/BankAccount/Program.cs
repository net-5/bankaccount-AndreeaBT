using System;

namespace BankAccount
{
    class Program
    {


        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("Commercial Bank");
            Account account = new Account($"Andreea-Teodora", "Nonexisting Client", 0);

            Console.WriteLine($"The {bank.BankName} has a private account  with the details : {account.Owner}.This account is {account.StatusOwner}.");
            Console.WriteLine($"The {bank.BankName} has a private account with the details : {account.NonExistingClient}\nStatus {account.StatusNonExisting} so there are no transactions allowed!");
            account.DepositOwner(600);
            account.Withdrawal(8000);
            account.DepositNonExisting(AccountStatus.Closed);
            account.WithdrawalNonExisting(AccountStatus.Closed);
            
        }
    }
}
