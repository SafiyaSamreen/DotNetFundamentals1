using System;

namespace DotnetStandardLibraryDemo
{
    public class DateNameConcatination
    {
        public void GetGreetings(string Username)
        {
            var time = DateTime.Now;

            Console.WriteLine(time + " " + "Hello, " + Username);

            Console.ReadLine();
        }
    }
}
