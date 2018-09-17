using System;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
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
                .Build();

            webbHost.Run();
        }
    }
}
