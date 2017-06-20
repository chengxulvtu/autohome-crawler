using System;
using System.Text;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Http;
using AutohomeCralwer.Core.Models;
using AutohomeCralwer.Core.Parser;
using AutohomeCralwer.EF.SQLServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace AutohomeCrawler
{
    class Program
    {

        public static IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            EncodingProvider provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            IServiceCollection services = new ServiceCollection();

            Configuration = new ConfigurationBuilder()
                .AddUserSecrets("FC097D1A-236E-448A-BAD8-1A8007266F5D")
                .Build();

            services.AddLogging();
            services.AddDbContext<AutohomeDbContext>(options =>
            {
                options.UseSqlServer(Configuration["AutohomeDbContext"], builder =>
                {
                    builder.MigrationsAssembly("AutohomeCralwer.EF.SQLServer");
                });
            });


            services.AddScoped<IJsonStore, FileJsonStore>();
            services.AddTransient<IBrandCralwer, BrandCralwer>();
            services.AddTransient<ISerieCralwer, SerieCralwer>();
            services.AddTransient<IBrandJson, BrandJson>();

            services.AddTransient<IBrandParser, BrandParser>();

            services.AddTransient<IBrandStore, AutohomeCralwer.EF.SQLServer.Store.BrandStore>();

            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ILoggerFactory>().AddConsole();

            var brandCralwer = serviceProvider.GetService<IBrandCralwer>();

            var brands = brandCralwer.GetBrandsAsync(GetBrandType.Normal).Result;

            //var serieCralwer = serviceProvider.GetService<ISerieCralwer>();

            foreach (var brand in brands)
            {
                Console.WriteLine($"{brand.Id}-{brand.Name}-{brand.PinYin}-{brand.BFirstLetter}");


                //var factories = serieCralwer.GetFactoriesAsync(brand.Id, GetSerieType.All).Result;

                //foreach (var factory in factories)
                //{
                //    Console.WriteLine($"{factory.Id}-{factory.Name}");

                //    foreach (var serie in factory.Series)
                //    {
                //        Console.WriteLine($"{serie.Id}-{serie.Name}-{serie.State}");
                //    }
                //}

            }




        }
    }
}
