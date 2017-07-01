using System;
namespace AutohomeCralwer.Core.Models
{
    public class CarType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaxPrice { get; set; }

        public int MinPrice { get; set; }

        public int State { get; set; }

        public int SerieId { get; set; }

        public int YearId { get; set; }



        #region 基本参数


        /// <summary>
        /// 车型名称
        /// </summary>
        public string FullName { get; set; }


        /// <summary>
        /// 厂商指导价（元）
        /// </summary>
        public string MGuidPrice { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public string CarTypeLevel { get; set; }

        /// <summary>
        /// 发动机
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// 变速箱
        /// </summary>
        public string GearBox { get; set; }

        /// <summary>
        /// 长*宽*高(mm)
        /// </summary>
        public string LWH { get; set; }

        /// <summary>
        /// 车身结构
        /// </summary>
        public string BodyStructure { get; set; }

        /// <summary>
        /// 最高车速(km/h)
        /// </summary>
        public string MaxSpeed { get; set; }

        /// <summary>
        /// 官方0-100km/h加速(s)
        /// </summary>
        public string OfficialAcc { get; set; }

        /// <summary>
        /// 实测0-100km/h加速(s)
        /// </summary>
        public string FactAcc { get; set; }

        /// <summary>
        /// 实测100-0km/h制动(m)
        /// </summary>
        public string FactBrake { get; set; }

        /// <summary>
        /// 实测油耗(L/100km)
        /// </summary>
        public string FactFuelConsumption { get; set; }

        /// <summary>
        /// 工信部综合油耗(L/100km)
        /// </summary>
        public string DepFuelConsumption { get; set; }

        /// <summary>
        /// 实测离地间隙(mm)
        /// </summary>
        public string FactGroundClearance { get; set; }

        /// <summary>
        /// 整车质保
        /// </summary>
        public string QualityAssurance { get; set; }

        #endregion


    }

    /// <summary>
    /// 获取车型类型
    /// </summary>
    public enum GetCarTypeType
    {
        Sale = 8,

        All = 5
    }
}
