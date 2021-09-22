using System;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            var version = typeof(Program).Assembly.GetName().Version;
            Console.WriteLine($"Updater {version}");
        }
    }
}
