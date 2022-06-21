using System;

namespace console_static
{
    public static class MyMath{
        public static float pi = 3.14f;
        public static int cube(int a){
            return (a*a*a);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of pi is ="+MyMath.pi);
            Console.WriteLine("The cube is = "+MyMath.cube(5));
        }
    }
}
