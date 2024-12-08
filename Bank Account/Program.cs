/*
Bank Account

Required:
Create a class named BankAccount.

The class contains:
AccountNumber.
Balance.
OwnerName.

Provide functions to:
Add money to the account (Deposit).
Withdraw money from the account (Withdraw) provided that the withdrawal is not greater than the balance.
Display account information.
Make the balance available only for external reading.
 */
namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bankAccount = new BankAccount();

                bankAccount.AccountNumber = 1572002;
                bankAccount.OwnerName = "Abdelwahab Ahmed Shandy";
                bankAccount.Deposit(10000);

                bankAccount.PrintInfoAccont();

                bankAccount.Withdraw(2000);

                bankAccount.PrintInfoAccont();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
        }
    }
}