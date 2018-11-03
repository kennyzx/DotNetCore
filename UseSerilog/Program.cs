using System;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace UseSerilog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

	    var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration) // the error happens here
            .CreateLogger();

            logger.Information("Hello, Serilog!");
        }
    }
}
