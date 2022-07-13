using System;

namespace console_stringequal
{
    class Program
    {
        static void Main(string[] args)
        {
            string password1 = "pass@123";
            string password2 = "pass@456";
            string password3 = "pass@123";
            Boolean result1= password1.Equals(password2);
            Boolean result2= password1.Equals(password3);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
