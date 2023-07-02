class DataTypes
{
    public void prgm1()
    {
        byte centuries = 20;
        ushort years = 2000;
        decimal decimalPI = 3.141592653589793238m;
        bool isEmpty = true;
        char ch = 'a';
        string firstName = "Anurag";
        Console.WriteLine("byte=" + centuries);
        Console.WriteLine("ushort=" + years);
        Console.WriteLine("decimal=" + decimalPI);
        Console.WriteLine("bool=" + isEmpty);
        Console.WriteLine("char=" + ch);
        Console.WriteLine("String=" + firstName);
        ch = (char)5;
        Console.WriteLine("conv of int to char =" + ch);

    }
}