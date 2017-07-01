using System;
using AutohomeCralwer.Core;
using AutohomeCralwer.Core.Http;
using AutohomeCralwer.Core.Parser;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutohomeServicesExtension
    {
        public static IAutohomeCralwerBuilder AddAutohomeCralwer(this IServiceCollection services)
        {
            services.AddTransient<IAutohomeCralwerBuilder, AutohomeCralwerBuilder>();

            services.AddTransient<IBrandCralwer, BrandCralwer>();
            services.AddTransient<ISerieCralwer, SerieCralwer>();
            services.AddTransient<ICarTypeCralwer, CarTypeCralwer>();
            services.AddTransient<ICralwer, Cralwer>();


            services.AddTransient<IBrandJson, BrandJson>();
            services.AddTransient<ISerieJson, SerieJson>();
            services.AddTransient<IYearJson, YearJson>();
            services.AddTransient<ICarTypeJson, CarTypeJson>();
            services.AddTransient<IJsonStore, FileJsonStore>();

            services.AddTransient<IBrandParser, BrandParser>();
            services.AddTransient<ISerieParser, SerieParser>();

            var serviceProvider = services.BuildServiceProvider();
            var builder = new AutohomeCralwerBuilder(services);

            return builder;
        }


    }
}
