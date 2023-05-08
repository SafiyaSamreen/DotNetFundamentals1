using System;

namespace DotNetStandardLibDemo
{
    public static class DateNameConcatination
    {
        public static string GetGreetings(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return "Please enter a proper Username";
            }

            return $"{DateTime.Now} Hello, {userName}";
        }
    }
}
