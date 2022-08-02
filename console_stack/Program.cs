using System;
using System.Collections;

namespace console_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Ram");
            myStack.Push("Sita");
            myStack.Push("Laxman");
            myStack.Push(null);
            myStack.Push(12);
            myStack.Push(12.34);
            myStack.Push("Hari");

            // foreach (var item in myStack)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("The total number of elements = "+myStack.Count);
            // Console.WriteLine("Element at top = "+myStack.Peek());

            // Console.WriteLine("Stack before popping");
            // foreach (var item in myStack)
            // {
            //     Console.WriteLine(item);
            // }

            // myStack.Pop();
            // myStack.Clear();

            // Console.WriteLine("Stack after popping");
            // foreach (var item in myStack)
            // {
            //     Console.WriteLine(item);
            // }

            Console.WriteLine("Is available ="+myStack.Contains("Hari"));
        }
    }
}
