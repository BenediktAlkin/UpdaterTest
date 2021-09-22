using System;
using System.Reflection;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var version = typeof(Program).Assembly.GetName().Version;
            Console.WriteLine($"Application {version}");
        }
    }
}
