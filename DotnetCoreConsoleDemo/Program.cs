using System;
using DotNetStandardLibDemo;

namespace DotnetCoreConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Please give the input parameter");
            }
            else
            {
                var name = args[1];
                var greetings = DateNameConcatination.GetGreetings(name);
                Console.WriteLine(greetings);
            }
        }
    }
}
