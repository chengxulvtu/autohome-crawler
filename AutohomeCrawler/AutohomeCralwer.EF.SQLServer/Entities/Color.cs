using System;
namespace AutohomeCralwer.EF.SQLServer.Entities
{
    public class Color
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int CarTypeId { get; set; }

        public virtual CarType CarType { get; set; }
    }
}
