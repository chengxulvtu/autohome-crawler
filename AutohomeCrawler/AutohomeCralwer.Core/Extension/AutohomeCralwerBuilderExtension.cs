using System;
using AutohomeCralwer.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutohomeCralwerBuilderExtension
    {
        public static IAutohomeCralwerBuilder AddJsonStore<T>(this IAutohomeCralwerBuilder builder) where T : class, IJsonStore
        {
            builder.Services.AddScoped<IJsonStore, T>();
            return builder;
        }


        public static IAutohomeCralwerBuilder AddBrandStore<T>(this IAutohomeCralwerBuilder builder) where T : class, IBrandStore
        {
            builder.Services.AddScoped<IBrandStore, T>();
            return builder;
        }

        public static IAutohomeCralwerBuilder AddFactoryStore<T>(this IAutohomeCralwerBuilder builder) where T : class, IFactoryStore
        {
            builder.Services.AddScoped<IFactoryStore, T>();
            return builder;
        }

        public static IAutohomeCralwerBuilder AddSerieStore<T>(this IAutohomeCralwerBuilder builder) where T : class, ISerieStore
        {
            builder.Services.AddScoped<ISerieStore, T>();
            return builder;
        }
    }
}
