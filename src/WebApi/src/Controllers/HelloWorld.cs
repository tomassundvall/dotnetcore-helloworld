using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApi
{
    [Route("[controller]")]
    public class HelloWorld : Controller
    {
        private ILogger<HelloWorld> _log;

        public HelloWorld(ILogger<HelloWorld> log)
        {
            _log = log;
            _log.LogInformation("Hello World Constructor");
            Console.WriteLine("Hello World Constructor");
        }


        [HttpGet]
        public string Get()
        {
            Console.WriteLine("GET /HelloWorld");
            return "Hello World";
        }
    }
}