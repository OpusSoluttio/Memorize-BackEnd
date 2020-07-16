﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApiHTTPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseKestrel(options =>
                //{
                //    options.Listen(IPAddress.Loopback, 5000);
                //    options.Listen(IPAddress.Loopback, 5001, listenOptions =>
                //    {
                //        listenOptions.UseHttps("Desktop/Assinado.pfx", "Senai@1324455");
                //    });

                //})
                .UseIISIntegration()
                .UseStartup<Startup>();
    }
}
