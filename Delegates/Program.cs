using System;

delegate string strMyDel(string str);

class TestDelegate
{
    public string changecase(string str)
    {
        return str.ToUpper();
    }

    public string reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

class Program
{
    static void Main()
    {
        TestDelegate testObj = new TestDelegate();
        strMyDel del1 = new strMyDel(testObj.changecase);
        strMyDel del2 = new strMyDel(testObj.reverse);
        strMyDel del3 = del1 + del2;

        string inputStr = "Hello World!";
        string resultStr1 = del1(inputStr);
        string resultStr2 = del2(inputStr);
        string resultStr3 = del3(inputStr);

        Console.WriteLine("Input string: " + inputStr);
        Console.WriteLine("Result after changecase(): " + resultStr1);
        Console.WriteLine("Result after reverse(): " + resultStr2);
        Console.WriteLine("Result after multicast delegate: " + resultStr3);
    }
}
