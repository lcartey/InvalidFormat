using System;

namespace InvalidFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = string.Format("class {0} { }", "C");
        }
    }
}
