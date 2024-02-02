using System.Diagnostics.CodeAnalysis;

namespace Cashier;
[ExcludeFromCodeCoverage]
public static class MenuExtension
{
    public static void WelcomeScreen()
    {
        Console.WriteLine("*************************************");
        Console.WriteLine("*    Welcome to your Bank Account   *");
        Console.WriteLine("*************************************");
        Console.WriteLine();
    }

    public static void ShowOptions()
    {
        Console.WriteLine("Select an operation:");
        Console.WriteLine("1. Withdraw Money");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Exit");
    }

    public static void ProcessOperation(string name, int option, double amount)
    {
        var operation = string.Empty;
        var bankAccount = new BankAccount(name, 1000); 
        switch (option)
        {
            case 1 :
                operation = "Withdraw Money";
                bankAccount.Debit(amount);
                break;
            case 2 :
                operation = "Deposit Money";
                bankAccount.Credit(amount);
                break;
        }
        Console.WriteLine($"Dear {name}, you have selected {operation} {amount:C}.");
        Console.WriteLine($"Your new balance is {bankAccount.Balance:C}.");
        Console.WriteLine("Successful operation, thank you for using our service!");
    }
}