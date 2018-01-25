﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ElectronNET.API;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseElectron(args)
                .UseStartup<Startup>()
                // .ConfigureAppConfiguration((builderContext, config) =>
                // {
                //     config.AddEnvironmentVariables();
                // })
                // .ConfigureLogging((hostingContext, builder) =>
                // {
                //     builder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                //     builder.AddConsole();
                //     builder.AddDebug();
                // })
                // .UseApplicationInsights()
                .Build();
    }
}
