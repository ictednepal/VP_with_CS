using System;

namespace console_ifelseifladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your obtain marks in Nepali :");
            int np = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your obtain marks in English :");
            int eg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your obtain marks in Science :");
            int sc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your obtain marks in Maths :");
            int mt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your obtain marks in Computer :");
            int cp = Convert.ToInt32(Console.ReadLine());
            int tom = np+eg+sc+mt+cp;
            Console.WriteLine("The total obtained marks is = "+tom);
            double per = tom/5;
            Console.WriteLine("Percentage = "+per);
            if(per>=80){
                Console.WriteLine("Distinction");
            }
            else if(per>=60){
                Console.WriteLine("First division");
            }
            else if(per>=45){
                Console.WriteLine("Second division");
            }
            else if(per>=32){
                Console.WriteLine("third division");
            }
            else{
                Console.WriteLine("Failed");
            }
        }
    }
}
