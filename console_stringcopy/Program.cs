using System;

namespace console_stringcopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string clzname = "Sanothimi";
            string name = string.Copy(clzname);
            Console.WriteLine(name);
        }
    }
}
