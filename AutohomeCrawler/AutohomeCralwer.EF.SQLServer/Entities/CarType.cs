using System;
namespace AutohomeCralwer.EF.SQLServer.Entities
{
    // 车型
    public class CarType
    {
        /// <summary>
        /// 车型Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 厂商指导价 Manufacturer's suggested retail price
        /// </summary>
        public string MSRP { get; set; }

        /// <summary>
        /// 经销商参考价 Dealer‘s reference price
        /// </summary>
        public string DRP { get; set; }

        #region 基本参数

        /// <summary>
        /// 厂商Id
        /// </summary>
        public int FactoryId { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        public virtual Factory Factory { get; set; }

        #endregion

        /// <summary>
        /// 级别
        /// </summary>
        public string Level { get; set; }

        // 最高车速（km/h)
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
        public string BasicWarranty { get; set; }


        /// <summary>
        /// 长（mm)
        /// </summary>
        public string Length { get; set; }

        /// <summary>
        /// 宽 (mm)
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// 高 (mm)
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// 轴距 (mm)
        /// </summary>
        public string Wheelbase { get; set; }

        /// <summary>
        /// 前轮距 (mm)
        /// </summary>
        public string FrontTrack { get; set; }

        /// <summary>
        /// 后轮距 (mm)
        /// </summary>
        public string RearTrack { get; set; }

        /// <summary>
        /// 最小离地间隙 (mm)
        /// </summary>
        public string GroundClearance { get; set; }

        /// <summary>
        /// 整备质量 (kg)
        /// </summary>
        public string CurbWeight { get; set; }

        /// <summary>
        /// 车身结构
        /// </summary>
        public string BodyStructure { get; set; }

        /// <summary>
        /// 行李箱容积 (L)
        /// </summary>
        public string CargoCapacity { get; set; }

        /// <summary>
        /// 油箱容积
        /// </summary>
        public string FuelTankCapacity { get; set; }

        /// <summary>
        /// 车门数
        /// </summary>
        public string TotalDoor { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        public string TotalSeating { get; set; }

        /// <summary>
        /// 发动机型号
        /// </summary>
        public string EngineType { get; set; }

        /// <summary>
        /// 排量 (mL)
        /// </summary>
        public string DisplacementML { get; set; }


        /// <summary>
        /// 排量
        /// </summary>
        public string Displacement { get; set; }

    }
}
