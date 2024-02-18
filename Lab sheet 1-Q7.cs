using System;

class Program
{
    static decimal balance = 1000; // Initial balance

    static void Main()
    {
        Console.WriteLine("Welcome to the ATM Simulator!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM Simulator. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your current balance: ${balance}");
    }

    static void DepositMoney()
    {
        Console.WriteLine("Enter the amount to deposit:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposit successful. Your new balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid input for deposit amount. Please enter a valid positive number.");
        }
    }

    static void WithdrawMoney()
    {
        Console.WriteLine("Enter the amount to withdraw:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for withdrawal amount. Please enter a valid positive number.");
        }
    }
}