// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100]; // Assuming a maximum of 100 numbers, adjust as needed
        int count = 0;
        int evenCount = 0;
        int positiveCount = 0;
        int totalPositive = 0;

        while (true)
        {
            Console.Write("Enter a number (enter 0 to end): ");
            string input = Console.ReadLine();

            if (input == "0")
                break;

            if (int.TryParse(input, out int num))
            {
                numbers[count] = num;
                count++;

                if (num % 2 == 0)
                    evenCount++;

                if (num > 0)
                {
                    positiveCount++;
                    totalPositive += num;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        if (count > 0)
        {
            double averagePositive = (double)totalPositive / positiveCount;

            Console.WriteLine("\nSummary:");
            Console.WriteLine($"Total numbers: {count}");
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Average of positive numbers: {averagePositive}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}

