using System;
using Serilog;

namespace UseSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    var log = new LoggerConfiguration()
    		.WriteTo.Console()
	        .CreateLogger();
            log.Information("Hello, Serilog!");
        }
    }
}
