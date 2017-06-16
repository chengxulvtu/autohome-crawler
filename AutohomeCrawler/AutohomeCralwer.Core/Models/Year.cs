using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AutohomeCralwer.Core.Models
{
    // 年限
    public class Year
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SerieId { get; set; }

        [JsonProperty("specitems")]
        public virtual List<CarType> CarTypes { get; set; } = new List<CarType>();
    }
}
