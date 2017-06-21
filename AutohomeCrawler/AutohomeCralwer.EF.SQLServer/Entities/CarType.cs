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
        public string BodyShellStruct { get; set; }

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

        /// <summary>
        /// 进气形式
        /// </summary>
        public string AirInForm { get; set; }

        /// <summary>
        /// 气缸排列形式
        /// </summary>
        public string CylinderArrangement { get; set; }

        /// <summary>
        /// 气缸数（个）
        /// </summary>
        public string CylinderNo { get; set; }

        /// <summary>
        /// 每缸气门数
        /// </summary>
        public string ValveNoPerCylinder { get; set; }

        /// <summary>
        /// 压缩比
        /// </summary>
        public string CompressRatio { get; set; }

        /// <summary>
        /// 配气机构
        /// </summary>
        public string ValveMechanism { get; set; }

        /// <summary>
        /// 缸径
        /// </summary>
        public string CylinderDiameter { get; set; }

        /// <summary>
        /// 行程
        /// </summary>
        public string Stroke { get; set; }

        /// <summary>
        /// 马力 (Ps）
        /// </summary>
        public string Horsepower { get; set; }

        /// <summary>
        /// 最大功率（kW)
        /// </summary>
        public string Power { get; set; }

        /// <summary>
        /// 最大功率转速 （rpm)
        ///</summary>
        public string PowerRevolvingSpeed { get; set; }

        ///<summary>
        /// 最大扭矩 (N·m)
        ///</summary>
        public string Torque { get; set; }

        ///<summary>
        /// 最大扭矩转速 (rpm)
        ///</summary>
        public string TorqueRevolvingSpeed { get; set; }

        ///<summary>
        /// 发动机特有技术
        ///</summary>
        public string EngineSpecialTech { get; set; }

        ///<summary>
        /// 燃料形式
        ///</summary>
        public string FuelType { get; set; }

        ///<summary>
        /// 燃油标号
        ///</summary>
        public string FuelLabel { get; set; }

        ///<summary>
        ///供油方式
        ///</summary>
        public string FuelSupply { get; set; }

        ///<summary>
        ///缸盖材料
        ///</summary>
        public string CylinderHeadMaterial { get; set; }

        ///<summary>
        ///缸体材料
        ///</summary>
        public string CylinderBodyMaterial { get; set; }

        ///<summary>
        ///环保标准
        ///</summary>
        public string EnvStandard { get; set; }


        ///<summary>
        /// 变速箱
        ///</summary>
        public string GearBox { get; set; }

        ///<summary>
        ///档位个数
        ///</summary>
        public string GearsNo { get; set; }

        ///<summary>
        ///变速箱类型
        ///</summary>
        public string GearBoxType { get; set; }

        ///<summary>
        ///驱动类型
        ///</summary>
        public string DriveType { get; set; }

        ///<summary>
        ///前悬架类型
        ///</summary>
        public string FrontSuspension { get; set; }

        ///<summary>
        ///后悬架类型
        ///</summary>
        public string RearSuspension { get; set; }

        ///<summary>
        ///助力类型
        ///</summary>
        public string PowerType { get; set; }

        ///<summary>
        /// 车体结构
        ///</summary>
        public string BodyStructure { get; set; }

        ///<summary>
        /// 前制动器类型
        ///</summary>
        public string FrontBrake { get; set; }

        ///<summary>
        ///后制动器类型
        ///</summary>
        public string RearBrake { get; set; }

        ///<summary>
        ///驻车制动类型
        ///</summary>
        public string ParkBrake { get; set; }

        ///<summary>
        ///前轮胎规格
        ///</summary>
        public string FrontTire { get; set; }

        ///<summary>
        ///后轮胎规格
        ///</summary>
        public string RearTire { get; set; }

        ///<summary>
        ///备胎规格
        ///</summary>
        public string SpareTire { get; set; }

        ///<summary>
        /// 主驾驶座安全气囊
        ///</summary>
        public string DriverAirBag { get; set; }

        ///<summary>
        ///副驾驶座安全气囊
        ///</summary>
        public string PassengerAirBag { get; set; }
        ///<summary>
        ///前排侧气囊
        ///</summary>
        public string FrontSideAirBag { get; set; }

        ///<summary>
        ///后排侧气囊
        ///</summary>
        public string RearSideAirBag { get; set; }

        ///<summary>
        ///前排头部气囊（气帘）
        ///</summary>
        public string FrontHeadAirBag { get; set; }

        ///<summary>
        /// 后排头部气囊（气帘）
        ///</summary>
        public string RearHeadAirBag { get; set; }

        ///<summary>
        ///膝部气囊
        ///</summary>
        public string KneeAirBag { get; set; }

        ///<summary>
        ///胎压监测装置
        ///</summary>
        public string TPMS { get; set; }
        ///<summary>
        ///零胎压继续行驶
        ///</summary>
        public string ZeroTirePressure { get; set; }

        ///<summary>
        ///安全带未系提示
        ///</summary>
        public string SeatBeltPrompt { get; set; }

        ///<summary>
        ///ISOFIX儿童座椅接口
        ///</summary>
        public string ISOFIX { get; set; }

        ///<summary>
        ///ABS防抱死
        ///</summary>
        public string ABS { get; set; }

        ///<summary>
        ///制动力分配
        ///</summary>
        public string EBD { get; set; }

        ///<summary>
        ///刹车辅助
        ///</summary>
        public string EBA { get; set; }

        ///<summary>
        ///牵引力控制
        ///</summary>
        public string MASR { get; set; }

        ///<summary>
        ///车身稳定控制
        ///</summary>
        public string ESC { get; set; }

        ///<summary>
        ///并线辅助
        ///</summary>
        public string SideAssist { get; set; }

        ///<summary>
        ///车道偏离预警系统
        ///</summary>
        public string LWDS { get; set; }

        ///<summary>
        ///主动刹车/主动安全系统
        ///</summary>
        public string ActiveBrakeAssist { get; set; }

        ///<summary>
        ///夜视系统 Night View Assist
        ///</summary>
        public string NVA { get; set; }

        ///<summary>
        ///前驻车雷达
        ///</summary>
        public string FrontParkRadar { get; set; }

        ///<summary>
        ///后驻车雷达
        ///</summary>
        public string RearParkRadar { get; set; }

        ///<summary>
        ///全景摄像头
        ///</summary>
        public string PanoramicCamera { get; set; }

        ///<summary>
        ///定速巡航
        ///</summary>
        public string CruiseControl { get; set; }

        ///<summary>
        ///自适应巡航 Adaptive Cruise Control
        ///</summary>
        public string ACC { get; set; }

        ///<summary>
        ///自动泊车入位
        ///</summary>
        public string ParkAssistVision { get; set; }

        ///<summary>
        ///发动机启停技术
        ///</summary>
        public string EngineStartStop { get; set; }

        ///<summary>
        ///上坡辅助 Hill-start Assist ControL
        ///</summary>
        public string HAC { get; set; }

        ///<summary>
        ///自动驻车
        ///</summary>
        public string AutoHold { get; set; }

        ///<summary>
        ///陡坡缓降系统
        ///</summary>
        public string HDC { get; set; }

///<summary>
///可变悬架
///</summary>
        public string AVS{get;set;}

///<summary>
///空气悬架
///</summary>
       public string AirSuspension{get;set;} 

///<summary>
///可变转向比
///</summary>
       public string VGRS{get;set;}

       
    }
}
