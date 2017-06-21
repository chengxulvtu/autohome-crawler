using System;
using System.Collections.Generic;

namespace AutohomeCralwer.EF.SQLServer.Entities
{
    public class Factory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstLetter { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public ICollection<Serie> Series = new List<Serie>();

    }
}
