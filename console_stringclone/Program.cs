using System;

namespace console_stringclone
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Sanothimi";
            string str2 = (String)str1.Clone();
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
