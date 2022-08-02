using System;
using System.Collections.Generic;

namespace console_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> numName = new Dictionary<int, string>();
            numName.Add(1,"One");
            numName.Add(2,"Two");
            numName.Add(3,"Three");
            numName.Add(4,"Four");
            numName.Add(5,"Five");
            numName.Add(6,"Six");
            foreach (KeyValuePair<int,string> item in numName)
            {
                Console.WriteLine("The key is {0} and its value is {1}.",item.Key,item.Value);
            }
        }
    }
}
