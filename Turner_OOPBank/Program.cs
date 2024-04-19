using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank(1000);

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            Console.WriteLine("3 - Check Balance");
            Console.WriteLine("4 - Quit");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Enter amount to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    bank.Deposit(depositAmount);
                    Console.WriteLine($"Deposited: {depositAmount:C2}. New Balance: {bank.Balance:C2}");
                    break;
                case "2":
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                    bank.Withdraw(withdrawalAmount);
                    Console.WriteLine($"Withdrawn: {withdrawalAmount:C2}. New Balance: {bank.Balance:C2}");
                    break;
                case "3":
                    Console.WriteLine($"Current Balance: {bank.Balance:C2}");
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
