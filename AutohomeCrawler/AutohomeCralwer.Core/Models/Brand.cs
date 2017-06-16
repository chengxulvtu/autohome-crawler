using System;
namespace AutohomeCralwer.Core.Models
{
    // 汽车品牌
    public class Brand
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PinYin { get; set; }

        public string BFirstLetter { get; set; }
    }

    // 获取汽车品牌的类型
    public enum GetBrandType
    {
        // 只获取
        Simple = 6,

        // 只获取
        Normal = 1,

        // 获取所有的品牌，包括一些跑车、赛道跑车品牌 新能源、电动车、未上市
        All = 11
    }
}
