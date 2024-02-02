namespace Cashier;

/// <summary>
/// Bank account demo class.
/// </summary>
public class BankAccount(string customerName, double balance)
{
    public string CustomerName { get; } = customerName;

    public double Balance => balance;

    public void Debit(double amount)
    {
        if (amount > balance)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount cannot be greater than the balance.");
        }

        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount cannot be negative.");
        }
        
        balance -= amount;
    }

    public void Credit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount cannot be negative.");
        }

        balance += amount;
    }
}