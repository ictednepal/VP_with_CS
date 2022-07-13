using System;

namespace console_stringconcatenate
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Ram ";
            string lname = "Thapa";
            string name = string.Concat(fname,lname);
            Console.WriteLine("The name is "+name);
        }
    }
}
