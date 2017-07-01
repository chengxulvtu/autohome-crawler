using System;
namespace Microsoft.Extensions.DependencyInjection
{
    public interface IAutohomeCralwerBuilder
    {
        IServiceCollection Services { get; }
    }


    public class AutohomeCralwerBuilder : IAutohomeCralwerBuilder
    {
        public AutohomeCralwerBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }
    }
}
