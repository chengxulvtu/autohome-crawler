﻿using System;
using System.Collections.Generic;

namespace AutohomeCralwer.EF.SQLServer.Entities
{
    public class Serie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstLetter { get; set; }

        public int State { get; set; }

        public int Order { get; set; }

        public int FactoryId { get; set; }

        public virtual Factory Factory { get; set; }

        public virtual ICollection<Year> Years { get; set; } = new List<Year>();
    }
}
