using System;
using System.Collections.Generic;

namespace AutohomeCralwer.EF.SQLServer.Entities
{
    public class Year
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SerieId { get; set; }

        public virtual Serie Serie { get; set; }

        public virtual ICollection<CarType> CarTypes { get; set; } = new List<CarType>();
    }
}
