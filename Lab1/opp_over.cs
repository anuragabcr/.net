using System;
class Square_Class
{
    private double Side;
    //public Constructor if int is passed convert to double and assign to Side
    public Square_Class(int s)
    {
        Console.WriteLine("constructor with int argument");
        Side = (double)s;
    }
    //OverLoaded constructor with double argument
    public Square_Class(double s)
    {
        Console.WriteLine("constructor with double argument");
        Side = s;
    }
    //override ToString() method of object class.
    public override string ToString()
    {
        Console.WriteLine("Override object class&#39;s string");
        return this.Side.ToString();
    }
    //Overloading + operator to add 2 Square_Class objects and return new Square_Class object
    public static Square_Class operator +(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading + with Square_Class,Square_Class");
        return new Square_Class(x.Side + y.Side);
    }
    //Overloading + operator to add Square_Class objects with double side and return new Square_Class object
    public static Square_Class operator +(Square_Class x, double y)
    {
        Console.WriteLine("Overloading + with Square_Class,double");
        return new Square_Class(x.Side + y);
    }
    //Overloading + operator to add Square_Class objects with int side and return new Square_Class object
    //This is not necessary since C# automatically calls +(Square_Class,double)
    public static Square_Class operator +(Square_Class x, int y)
    {
        Console.WriteLine("Overloading + with Square_Class,int");
        return x + (double)y;
    }
    public static implicit operator Square_Class(double s)
    {

        Console.WriteLine("Overloading = for Square_Class s5=1.5 assignment");
        return new Square_Class(s);
    }
    public static implicit operator Square_Class(int s)
    {
        Console.WriteLine("Overloading = for Square_Class s5=10 assignment");
        return new Square_Class((double)s);
    }
    //OverLoading == operator
    public static bool operator ==(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading == with Square_Class,Square_Class");
        return x.Side == y.Side;
    }
    //OverLoading != operator
    public static bool operator !=(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading != with Square_Class,Square_Class");
        return !(x == y); //This will call to operator == simple way to implement !=
    }
    //Always override GetHashCode(),Equals when overloading ==
    public override bool Equals(object o)
    {
        return this == (Square_Class)o;
    }
    public override int GetHashCode()
    {
        return (int)Side;
    }
    //OverLoading &gt; operator
    public static bool operator >(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading &gt; with Square_Class,Square_Class");
        return x.Side > y.Side;
    }
    //OverLoading &lt; operator
    public static bool operator <(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading &lt; with Square_Class,Square_Class");
        return x.Side < y.Side;
    }
    //OverLoading &lt;= operator
    public static bool operator <=(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading &lt;= with Square_Class,Square_Class");
        return (x < y) || (x == y); //Calls to operator == and &lt;
    }
    //OverLoading &gt;= operator

    public static bool operator >=(Square_Class x, Square_Class y)
    {
        Console.WriteLine("Overloading &gt;= with Square_Class,Square_Class");
        return (x > y) || (x == y); //Calls to operator == and &gt;
    }
    //Readonly Property
    public double Area
    {
        get
        {
            return 2 * Side;
        }
    }
    public void call_main()
    {
        Console.WriteLine("Dreamy Medhi 21DMMCA019");
        Square_Class s1 = new Square_Class(10);
        Square_Class s2 = new Square_Class(20);
        Square_Class s3 = s1 + s2; // This will call operator + (Square_Class,Square_Class)
        Console.WriteLine(s3);
        Console.WriteLine(s3 + 15); // This will call operator + (Square_Class,int) and then
        s3.ToString();
        Console.WriteLine(s3 + 1.5); // This will call operator + (Square_Class,double) and then ToString()
        s3 = 10; // This will call operator Square_Class(int)
        Console.WriteLine(s3);
        Square_Class s4 = 10;
        Console.WriteLine(s1 == s4); //Calls == operator
        Console.WriteLine(s1 != s4); //Calls != operator
        Console.WriteLine(s1 > s2); //Calls &gt; operator
        Console.WriteLine(s1 <= s4); //Calls &lt;= operator
    }
}