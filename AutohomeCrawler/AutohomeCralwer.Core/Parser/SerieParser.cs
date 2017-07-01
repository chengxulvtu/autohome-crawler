using System;
using System.Collections.Generic;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Parser
{
    public interface ISerieParser
    {
        IEnumerable<Factory> Parse(int brandId, string json);
    }

    public class SerieParser : ISerieParser
    {
        public IEnumerable<Factory> Parse(int brandId, string json)
        {
            var factories = JsonConvert.DeserializeObject<List<Factory>>(json);

            foreach (var factory in factories)
            {
                factory.BrandId = brandId;

                foreach (var series in factory.Series)
                {
                    series.FactoryId = factory.Id;
                    series.Factory = factory.Name;
                    series.BrandId = brandId;
                }
            }

            return factories;
        }
    }
}
