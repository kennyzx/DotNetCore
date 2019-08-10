using System;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace UseMicrosoftExtensionsLogging
{
    public class PeopleProcessor
    {
        public static void DisplayPersonDetail()
        {
            PersonModel person = new PersonModel { Name = "abc", Age = 123 };

            var factory = new LoggerFactory()
                        .AddConsole(LogLevel.Trace);
                
            ILogger logger = factory.CreateLogger<PeopleProcessor>();

            Console.WriteLine($"Hello {JsonConvert.SerializeObject(person)}!");
            
            logger.Log(LogLevel.Critical, "something went wrong!");
        }
    }
}