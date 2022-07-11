using System;

namespace console_dedegateanonymoustwo
{
    public delegate void myDel(string name);

    class Program
    {
        
        static void Main(string[] args)
        {
            //string address = "Kathmandu";
            myDel md1 = delegate(string name){
                Console.WriteLine("Hello "+name);
                //Console.WriteLine("You live in "+ address);
            };
            md1("Ram");
        }
    }
}
