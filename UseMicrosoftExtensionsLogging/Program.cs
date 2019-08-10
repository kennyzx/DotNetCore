using System;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace UseMicrosoftExtensionsLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            NLog.LogManager.LoadConfiguration("nlog.config");

            var factory = new LoggerFactory()
                    .AddNLog();
            
            ILogger logger = factory.CreateLogger<Program>();

            logger.Log(LogLevel.Information, "step 1");
            
            PeopleProcessor.DisplayPersonDetail();
        }
    }
}
