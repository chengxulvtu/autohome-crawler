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
            services.AddTransient<IBrandCralwer, BrandCralwer>();

            var serviceProvider = services.BuildServiceProvider();
            var cralwer = serviceProvider.GetService<IBrandCralwer>();

            var brands = cralwer.GetBrandsAsync(GetBrandType.Normal).Result;

            foreach (var item in brands)
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.PinYin}-{item.BFirstLetter}");
            }




        }
    }
}
