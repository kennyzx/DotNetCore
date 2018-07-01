using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreMVC
{
    public class Program
    {
        public static IConfiguration Configuration { get; set; }

        public static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddCommandLine(args);
            Configuration = builder.Build();
            BuildWebHost(args).Run();
        }

        //Command line:  dotnet run --ASPNETCORE_ENVIRONMENT=Development -p ASPNETCoreMVC/ASPNETCoreMVC.csproj
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseEnvironment(Configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT"))
                .UseStartup<Startup>()
                .Build();
    }
}
