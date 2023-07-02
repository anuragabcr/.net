class EvenOdd
{
    public void prgm6()
    {
        Console.Write("Enter a No.:- ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a + " is a " + (a % 2 == 0 ? "Even" : "Odd"));
    }
}