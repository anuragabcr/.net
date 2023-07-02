using System;

class Program
{
    static int ReadNumber(int start, int end)
    {
        Console.Write($"Enter an integer between {start} and {end}: ");
        int num = 0;
        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter an integer.");
            return ReadNumber(start, end);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine($"Invalid input! Please enter an integer between {start} and {end}.");
            return ReadNumber(start, end);
        }
        return num;
    }

    static void Main()
    {
        int[] arr = new int[10];
        int start = 1;
        int end = 100;
        arr[0] = ReadNumber(start, end);

        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] = ReadNumber(arr[i - 1], end);
        }

        Console.WriteLine("You entered the following numbers:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
