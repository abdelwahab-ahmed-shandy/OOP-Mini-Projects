/*
 // Inheritance & operator overloading

You are provided with a simple Account class

An Account has a name and a balance.

I have also provided some Account helper functions in AccountUtil
that make it easy to display, deposit to, and withdraw from a list of Accounts.

Your task is the following:

1. Add a Savings Account class to the Account hierarchy and adds an interest rata.

2. Add a Checking account class to the Account hierarchy
    A Checking account has a name and a balance and has a fee of $1.50 per withdrawal transaction.
    Every withdrawal transaction will be assessed this flat fee.

3. Add a Trust account class to the Account hierarchy
    A Trust account has a name, a balance, and an interest rate
    The Trust account deposit works just like a savings account deposit.
    However, any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.
   
    The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance.
    
4. Overload + operator in Account class (to sum the balances of two objects you will be create in Main)


Hints: 
    Reuse existing functionality!!
    override to string always!
 */
namespace Bank_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            Console.WriteLine("\tAccounts :");
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            Console.WriteLine("\n\tSaving Accounts :");
            var savAccounts = new List<Account>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 20000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 50000, 5.0));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            Console.WriteLine("\n\tChascking Accounts :");
            var checAccounts = new List<Account>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            Console.WriteLine("\n\tTrust Accounts :");
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Display(trustAccounts);
            Console.WriteLine("Add 5000 Bouns 50 :");
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);

            Console.WriteLine("\nCheck 3 Widthrawal :");
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            //operating overloading
            Console.WriteLine("\n\tOperating Overloading");
            Account acc1 = new Account();
            Account acc2 = new Account();
            Console.WriteLine(acc1 + acc2);

            Console.WriteLine();
        }
    }
}
