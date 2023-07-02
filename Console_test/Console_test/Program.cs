using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_test
{
    public delegate void strMyDel(string str);
    class TestDelegate
    {

        public void changecase(string str1)
        {
            char[] arr1 = str1.ToCharArray();
            Console.Write("After the conversion the string is : ");
            foreach (char ch in arr1)
            {
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }
            Console.Write("\n\n");
        }

        public void revString(String s2)
        {
            string rev = "";
            Console.WriteLine("Before inversion the string  is{0} ", s2);
            int len = s2.Length - 1;
            while (len >= 0)
            {
                rev = rev + s2[len];
                len--;
            }

            Console.WriteLine("After Coversion the string is:{0}", rev);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestDelegate s = new TestDelegate();
            strMyDel d = new strMyDel(s.changecase);
            d += s.revString;
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            d.Invoke(sentence);
            Console.ReadLine();
        }
    }
}
