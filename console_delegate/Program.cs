using System;

namespace console_delegate
{
    public delegate void myDel(string name);
    class Program
    {
        public static void displayName(string name){
            Console.WriteLine("The name is = "+name);
        }
        static void Main(string[] args)
        {
            myDel md1 = new myDel(displayName);
            md1("Sanothimi");
        }
    }
}
