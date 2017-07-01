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

        public virtual ICollection<Factory> Factories { get; set; } = new List<Factory>();
    }
}
