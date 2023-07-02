using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_prgm_3
{
    class NotInRangeException : Exception
    {
        public NotInRangeException(string msg) : base(msg) { }
    }
    class Program
    {
        static int readNumber(int start, int end)
        {
            Console.Write("Enter an integer in the range [{0}, {1}]: ", start, end);
            int num=int.Parse(Console.ReadLine());
            if (num < start || num > end) {
                throw new NotInRangeException("Number not in range");
            }
            return num;
        }
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int[] numbers = new int[10];
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = readNumber(start, end);
                    start = numbers[i] + 1;
                }

                Console.WriteLine("The entered numbers are:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
