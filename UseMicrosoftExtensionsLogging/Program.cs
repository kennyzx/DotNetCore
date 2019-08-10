using System;
using Microsoft.Extensions.Logging;

namespace UseMicrosoftExtensionsLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new LoggerFactory()
                    .AddConsole(LogLevel.Trace);
            
            ILogger logger = factory.CreateLogger<Program>();

            logger.Log(LogLevel.Debug, "step 1");
            
            PeopleProcessor.DisplayPersonDetail();
        }
    }
}
