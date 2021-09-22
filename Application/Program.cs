using System;
using System.Reflection;
using System.Threading;

namespace Application
{
    public class Program
    {
        public static void Main()
        {
            var version = typeof(Program).Assembly.GetName().Version;
            Console.WriteLine($"Application {version}");
            Thread.Sleep(1000);
            Console.WriteLine($"finished");
        }
    }
}
