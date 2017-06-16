using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Models
{
    public class Factory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstLetter { get; set; }

        public int BrandId { get; set; }

        [JsonProperty("seriesitems")]
        public virtual List<Serie> Series { get; set; } = new List<Serie>();
    }
}
