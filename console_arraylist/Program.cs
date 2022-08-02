using System;
using System.Collections;

namespace console_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nameList = new ArrayList();
            nameList.Add("Ram");
            nameList.Add("Sita");
            nameList.Add("Nita");
            // foreach (var item in nameList)
            // {
            //     string arrayItem = string.Format($"Name is {item}");
            //     Console.WriteLine(arrayItem);
            // }

            Console.WriteLine("==========Original List ==============");
            for(int i = 0; i<nameList.Count;i++)
            {
                string arrayItem = string.Format($"Name is {nameList[i]}");
                Console.WriteLine(arrayItem);
            }
            // nameList.Insert(1,"Gita");
            // nameList.Remove("Sita");
            nameList.RemoveAt(2);
            Console.WriteLine("==========Momdify List ==============");
            for(int i = 0; i<nameList.Count;i++)
            {
                string arrayItem = string.Format($"Name is {nameList[i]}");
                Console.WriteLine(arrayItem);
            }
        }
    }
}
