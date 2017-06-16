using System;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Models
{
    public class Serie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstLetter { get; set; }

        [JsonProperty(PropertyName = "SeriesState")]
        public int State { get; set; }

        [JsonProperty(PropertyName = "SeriesOrder")]
        public int Order { get; set; }

        public int FactoryId { get; set; }

        public string Factory { get; set; }

        public int BrandId { get; set; }
    }

    public enum GetSerieType
    {
        // 在售 
        OnlyOnSale = 7,

        // 在售和停售
        OnAndHaltSale = 3,

        // 未上市、在售和停售
        All = 13
    }
}
