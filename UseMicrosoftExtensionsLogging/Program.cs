using System;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;


namespace UseMicrosoftExtensionsLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new LoggerFactory()
                    .AddConsole(LogLevel.Debug);
            PersonModel person = new PersonModel { Name = "abc", Age = 123};
            ILogger logger = factory.CreateLogger<Program>();

            logger.Log(LogLevel.Debug, "step 1");
            Console.WriteLine($"Hello {JsonConvert.SerializeObject(person)}!");
            logger.Log(LogLevel.Debug, "step 2");
        }
    }
}
