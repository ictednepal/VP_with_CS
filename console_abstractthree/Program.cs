using System;

namespace console_abstractthree
{
    public abstract class HelloNepal
    {
        public abstract void hello();
    }
    public class Kathmandu : HelloNepal
    {
        public override void hello()
        {
            Console.WriteLine("Hello Kathmandu");
        }
    }
    public class Bhaktapur : HelloNepal
    {
        public override void hello()
        {
            Console.WriteLine("Hello Bhaktapur");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HelloNepal n;
            n = new Kathmandu();
            n.hello();
            n = new Bhaktapur();
            n.hello();
        }
    }

}
