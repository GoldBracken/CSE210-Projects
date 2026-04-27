using System;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> arr = new List<int>();
        int num = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                break;
            }
            arr.Add(num);
        }
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        double average = arr.Average();
        int max = arr.Max();
        int min = arr[0];
        foreach (int i in arr)
        {
            if (min > i && i > 0)
            {
                min = i;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest positive number is {min}");
        arr.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}