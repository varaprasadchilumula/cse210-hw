using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of number, type 0 when finished.");

        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        // Sum of list 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Average of list
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Max of list
        int max = numbers[0];
        max = numbers.Max(); // using .Max() method

        // foreach loop method
        // foreach (int number in numbers)
        // {
        //     if (number > max)
        //     {
        //         max = number;
        //     }
        // }
        Console.WriteLine($"The max is: {max}");

    }
}