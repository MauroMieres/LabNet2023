using System;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.WriteLine("Hello World!");
                Thread.Sleep(1000);
            }       
        }
    }
}
