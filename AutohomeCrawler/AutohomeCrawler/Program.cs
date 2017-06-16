using System;
using System.Text;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AutohomeCrawler
{
    class Program
    {

        static void Main(string[] args)
        {
            EncodingProvider provider = CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(provider);

            IServiceCollection services = new ServiceCollection();

            services.AddScoped<IJsonStore, FileJsonStore>();

            services.AddTransient<IBrandCralwer, BrandCralwer>();
            services.AddTransient<ISerieCralwer, SerieCralwer>();

            var serviceProvider = services.BuildServiceProvider();
            var brandCralwer = serviceProvider.GetService<IBrandCralwer>();

            var brands = brandCralwer.GetBrandsAsync(GetBrandType.Normal).Result;

            var serieCralwer = serviceProvider.GetService<ISerieCralwer>();

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
