using System;
using System.Collections.Generic;
using AutohomeCralwer.Core.Models;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Parser
{
    public interface IBrandParser
    {
        IEnumerable<Brand> Parse(string json);
    }

    public class BrandParser : IBrandParser
    {
        public IEnumerable<Brand> Parse(string json)
        {
            if (!string.IsNullOrWhiteSpace(json))
            {
                var brands = JsonConvert.DeserializeObject<IEnumerable<Brand>>(json);
                return brands;
            }
            return new List<Brand>();
        }
    }
}
