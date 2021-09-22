using System;
using System.IO;

namespace Updater
{
    public class Program
    {
        public const string TEMP_DIR = "temp";
        private const string DIR_IN_ZIP = "Application";

        public static void Main(string[] args)
        {
            var version = typeof(Program).Assembly.GetName().Version;
            Console.WriteLine($"Updater {version}");

            var path = Path.Combine(TEMP_DIR, DIR_IN_ZIP);

            foreach (var dir in Directory.GetDirectories(path))
            {
                var dstPath = dir[(path.Length + 1)..^0];
                if (Directory.Exists(dstPath))
                    Directory.Delete(dstPath, true);
                Directory.Move(dir, dstPath);
            }
            foreach(var file in Directory.GetFiles(path))
            {
                var dstPath = file[(path.Length + 1)..^0];
                File.Move(file, dstPath, true);
            }
        }
    }
}
