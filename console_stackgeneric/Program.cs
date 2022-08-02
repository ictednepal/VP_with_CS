using System;
using System.Collections.Generic;

namespace console_stackgeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(34);
            myStack.Push(2);
            myStack.Push(1);
            myStack.Push(56);
            myStack.Push(34);
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
