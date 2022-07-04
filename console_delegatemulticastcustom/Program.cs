//creating custom multicast delegate and event
using System;

namespace console_delegatemulticastcustom
{
    class Program
    {
        public delegate void MyDelegate(int a, int b);
        public class MCD
        {
            public event MyDelegate MyEvent;
            public void RaiseEvent(int a, int b)
            {
                MyEvent(a, b);
                Console.WriteLine("Event Raised");
            }
            public void Add(int x, int y)
            {
                Console.WriteLine("Add Method {0}", x + y);
            }
            public void Subtract(int x, int y)
            {
                Console.WriteLine("Subtract Method {0}", x - y);
            }
        }
        static void Main(string[] args)
        {

            MCD obj = new MCD();
            obj.MyEvent += new MyDelegate(obj.Add);
            obj.MyEvent += new MyDelegate(obj.Subtract);
            obj.RaiseEvent(20, 10);
        }
    }
}
