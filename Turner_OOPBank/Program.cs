using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank(1000);
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    PerformDeposit(bank);
                    break;
                case "2":
                    PerformWithdrawal(bank);
                    break;
                case "3":
                    DisplayBalance(bank);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Deposit");
        Console.WriteLine("2 - Withdraw");
        Console.WriteLine("3 - Check Balance");
        Console.WriteLine("4 - Quit");
    }

    private static void PerformDeposit(Bank bank)
    {
        Console.Write("Enter amount to deposit: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
        {
            bank.Deposit(Math.Round(depositAmount, 2));
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid decimal number.");
        }
    }

    private static void PerformWithdrawal(Bank bank)
    {
        Console.Write("Enter amount to withdraw: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
        {
            bank.Withdraw(Math.Round(withdrawalAmount, 2));
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a valid decimal number.");
        }
    }

    private static void DisplayBalance(Bank bank)
    {
        Console.WriteLine($"Current Balance: {bank.Balance:C2}");
    }
}
