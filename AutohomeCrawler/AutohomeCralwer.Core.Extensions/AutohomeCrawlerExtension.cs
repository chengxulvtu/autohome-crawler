using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AutohomeCrawlerExtension
    {
        public static IApplicationBuilder AddAuthomeCralwer(this IApplicationBuilder app, Action<AutohomeOption> options)
        {


            return app;
        }
    }



    public class AutohomeOption
    {

    }
}
