using System;
abstract class AreaClass
{
    abstract public int Area();
}
class Square : AreaClass
{
    int side = 0;
    public Square(int n)
    {
        side = n;
    }
    public override int Area()
    {
        return side * side;
    }
}

class Absmain
{
    public void call_main()
    {
        Square s = new Square(6);
        Console.WriteLine("Area: ", s.Area());
    }
}