class ReverseNum
{
    public void prgm7()
    {
        Console.WriteLine("Enter a Num:- ");
        int num = int.Parse(Console.ReadLine());
        int rev = 0, temp = num;
        while (num > 0)
        {
            int rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }
        Console.WriteLine(temp + " reverse is " + rev);
    }
}