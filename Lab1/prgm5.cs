class LargestTwo
{
    public void prgm5()
    {
        Console.WriteLine("Enter First No.:- ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second No.:- ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Largest of two no. is :-" + (a > b ? a : b));
    }
}