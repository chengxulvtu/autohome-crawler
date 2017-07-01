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
                .AddUserSecrets<Program>()
                .Build();

            services.AddLogging();
            services.AddDbContext<AutohomeDbContext>(options =>
            {
                options.UseSqlServer(Configuration["AutohomeDbContext"], builder =>
                {
                    builder.MigrationsAssembly("AutohomeCralwer.EF.SQLServer");
                });
            });

            services.AddAutohomeCralwer()
                    .AddBrandStore<AutohomeCralwer.EF.SQLServer.Store.BrandStore>()
                    .AddFactoryStore<AutohomeCralwer.EF.SQLServer.Store.FactoryStore>()
                    .AddSerieStore<AutohomeCralwer.EF.SQLServer.Store.SerieStore>();


            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ILoggerFactory>().AddConsole();


            //var carTypeJson = serviceProvider.GetService<ICarTypeJson>();
            //var json = carTypeJson.GetJsonAsync(2903, 6457).Result;
            //Console.WriteLine(json);

            //var brandCralwer = serviceProvider.GetService<IBrandCralwer>();
            //var brands = brandCralwer.GetBrandsAsync(GetBrandType.Normal).Result;

            //var serieCralwer = serviceProvider.GetService<ISerieCralwer>();

            //var brandStore = serviceProvider.GetService<IBrandStore>();

            //var task = brandStore.PersistBrandsAsync(brands);

            //task.ContinueWith(t =>
            //{
            //    Console.WriteLine("success");
            //});

            var autohomeCralwer = serviceProvider.GetService<ICralwer>();
            //autohomeCralwer.CralwerAsync().ContinueWith(t =>
            //{
            //    Console.WriteLine("success");
            //    t.Wait();
            //});

            autohomeCralwer.CralwerAsync().ContinueWith(t =>
            {
                Console.WriteLine("success");
                t.Wait();
            });


            //foreach (var brand in brands)
            //{
            //Console.WriteLine($"{brand.Id}-{brand.Name}-{brand.PinYin}-{brand.BFirstLetter}");





            //var factories = serieCralwer.GetFactoriesAsync(brand.Id, GetSerieType.All).Result;

            //foreach (var factory in factories)
            //{
            //    Console.WriteLine($"{factory.Id}-{factory.Name}");

            //    foreach (var serie in factory.Series)
            //    {
            //        Console.WriteLine($"{serie.Id}-{serie.Name}-{serie.State}");
            //    }
            //}

            //}




        }
    }
}
