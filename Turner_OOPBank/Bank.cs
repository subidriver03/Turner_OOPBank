public class Bank
{
    private decimal balance;

    public Bank(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public decimal Deposit(decimal amount)
    {
        balance += amount;
        return balance;
    }

    public decimal Withdraw(decimal amount)
    {
        if (amount > 500)
            amount = 500;
        if (balance >= amount)
            balance -= amount;
        else
            balance = 0;
        return balance;
    }

    public decimal Balance
    {
        get { return balance; }
    }
}
