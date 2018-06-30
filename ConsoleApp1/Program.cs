using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine("Open a file...");
            Console.ForegroundColor = ConsoleColor.White;
            if (File.Exists("/etc/apache2/apache2.conf"))
            {
                foreach (var line in File.ReadAllLines("/etc/apache2/apache2.conf"))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
