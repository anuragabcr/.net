using System;
class BaseClass
{
    public virtual int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
class ChildClass : BaseClass
{
    public override int Add(int num1, int num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            Console.WriteLine("Zero entered\n Enter num1:- ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zero entered\n Enter num2:- ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        return base.Add(num1, num2);
    }
}

class Override
{
    public void call_main()
    {
        BaseClass baseClass = new BaseClass();
        Console.WriteLine("Base: " + baseClass.Add(-3, 8));
        baseClass = new ChildClass();
        Console.WriteLine("Base: " + baseClass.Add(-3, 8));
    }
}