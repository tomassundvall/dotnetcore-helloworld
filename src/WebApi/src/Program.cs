using System;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

namespace WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Debug)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            var webbHost = new WebHostBuilder()
                .UseKestrel(opt =>
                {
                    opt.Listen(IPAddress.Any, 5001);
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .UseStartup<Startup>()
                .UseSerilog((hostingContext, config) =>
                {
                    config.ReadFrom.Configuration(hostingContext.Configuration);
                    config.Enrich.FromLogContext();
                })
                .Build();

            webbHost.Run();
        }
    }
}
