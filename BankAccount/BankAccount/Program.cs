using System;

namespace BankAccount
{
    class Program
    {


        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("Commercial Bank");
            Account account = new Account($"Andreea-Teodora", 2789);
            AccountTwo accountTwo = new AccountTwo("Alexandru Georgiana", 0);

            Console.WriteLine($"The {bank.BankName} has a private account  with the details : {account.OwnerOne}.This account is {account.StatusOne}.");
            Console.WriteLine($"The {bank.BankName} has a private account with the details : {accountTwo.OwnerTwo},\nWith the status {accountTwo.StatusTwo} so there are no transactions allowed!");
            account.Deposit(600);
            account.WithdrawalOne(8000);
            accountTwo.DepositTwo(200);
            accountTwo.WithdrawalTwo(200);
        }
    }
}
