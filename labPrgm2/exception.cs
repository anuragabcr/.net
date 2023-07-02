using System;
// namespace exceptionHandling
// {
class NotInRangeException : Exception
{
    public NotInRangeException(string str) : base(str)
    {
        Console.WriteLine("Out of range");
    }
}
class ExceptionProgram
{
    public static void ReadNumber(int start, int end)
    {
        int count = 1, number = 0;
        try
        {
            if (end < start)
            {
                throw new NotInRangeException("End cann't be less than start");
            }
            else if (end <= start + 10)
            {
                throw new NotInRangeException("Wrong range of input");
            }
            do
            {
                Console.WriteLine("Number{0}: ", count);
                number = int.Parse(Console.ReadLine());
                if (number < start)
                {
                    throw new NotInRangeException("Input cann't be less than " + start);
                }
                else if (number > end)
                {
                    throw new NotInRangeException("Input cann't be greater than " + end);
                }
                count++;
            } while (count < 11);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Entered value is not a valid integer.");
        }
        catch (NotInRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error:- " + e.Message);
        }
        finally
        {
            Console.WriteLine("\n------End of the Program");
        }
    }
    public void callMain()
    {
        try
        {
            Console.WriteLine("Start:- ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("End:");
            int end = int.Parse(Console.ReadLine());
            ReadNumber(start, end);
        }
        catch (Exception e)
        {

            Console.WriteLine("Error:- " + e.Message);
        }
    }
}
// }