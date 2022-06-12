using System;

namespace console_break
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
