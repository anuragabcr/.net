using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_prgm_2
{
    public delegate void strMyDel(string str);

    public class TestDelegate
    {
        public void ChangeCase(string str)
        {
            string result = "";

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else if (char.IsLower(c))
                    result += char.ToUpper(c);
                else
                    result += c;
            }

            Console.WriteLine("Changed Case: " + result);
        }

        public void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);

            Console.WriteLine("Reversed String: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();

            strMyDel myDel = testDelegate.ChangeCase;
            myDel += testDelegate.Reverse;

            myDel("Hello World");
            Console.ReadLine();
        }
    }
}
