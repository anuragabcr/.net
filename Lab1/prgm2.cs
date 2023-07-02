class ReadingNumbers
{
    public void Lab2()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine(a + "* " + b + "=" + a * b);
        Console.Write("f = ");
        double f = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f);
    }
}