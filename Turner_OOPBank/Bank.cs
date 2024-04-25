public class Bank
{
    private decimal balance;

    public Bank(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount:C2}. New Balance: {balance:C2}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance. Transaction cancelled.");
            return;
        }

        if (amount > 500)
        {
            Console.WriteLine("Withdrawal amount exceeds the limit of $500. Transaction cancelled.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:C2}. New Balance: {balance:C2}");
    }

    public decimal Balance => balance;
}
