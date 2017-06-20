using System;
using System.Collections.Generic;

namespace AutohomeCralwer.EF.SQLServer.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PinYin { get; set; }

        public string FirstLetter { get; set; }

        public ICollection<Factory> Factories = new List<Factory>();

        public ICollection<Serie> Series = new List<Serie>();
    }
}
