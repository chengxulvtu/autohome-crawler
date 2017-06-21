using System;
using System.Collections.Generic;


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
        /// 厂商
        /// </summary>
        public string Factory { get; set; }

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
        public string AVS { get; set; }

        ///<summary>
        ///空气悬架
        ///</summary>
        public string AirSuspension { get; set; }

        ///<summary>
        ///可变转向比
        ///</summary>
        public string VGRS { get; set; }

        ///<summary>
        ///前桥限滑差速器
        ///</summary>
        public string FrontDifferential { get; set; }

        ///<summary>
        ///中央限滑差速器
        ///</summary>
        public string CentralDifferential { get; set; }

        ///<summary>
        ///后桥限滑差速器
        ///</summary>
        public string RearDifferential { get; set; }

        ///<summary>
        ///整体主动转向系统
        ///</summary>
        public string IntegralActiveSteering { get; set; }

        ///<summary>
        ///电动天窗
        ///</summary>
        public string PowerSunroof { get; set; }


        ///<summary>
        ///全景天窗
        ///</summary>
        public string PanoramicSunroof { get; set; }

        ///<summary>
        ///运动外观套件
        ///</summary>
        public string SportPackage { get; set; }

        ///<summary>
        ///铝合金钢圈
        ///</summary>
        public string LumminumRim { get; set; }

        ///<summary>
        ///电吸门
        ///</summary>
        public string ElecSuctionDoor { get; set; }

        ///<summary>
        ///侧滑门
        ///</summary>
        public string SideSlidingDoor { get; set; }

        ///<summary>
        ///电动后备箱
        ///</summary>
        public string ElecTrunk { get; set; }

        ///<summary>
        ///感应后备箱
        ///</summary>
        public string SensingTrunk { get; set; }

        ///<summary>
        ///车顶行李架
        ///</summary>
        public string RoofRack { get; set; }

        ///<summary>
        ///发动机电子防盗
        ///</summary>
        public string IMMO { get; set; }

        ///<summary>
        ///车内中控锁
        ///</summary>
        public string CentralLocking { get; set; }

        ///<summary>
        ///遥控钥匙
        ///</summary>
        public string RKE { get; set; }

        ///<summary>
        ///无钥匙启动系统
        ///</summary>
        public string PEPS { get; set; }

        ///<summary>
        ///无钥匙进入系统
        ///</summary>
        public string PKE { get; set; }

        ///<summary>
        ///真皮方向盘 Leather Steering Wheel
        ///</summary>
        public string LeatherSW { get; set; }

        ///<summary>
        ///方向盘调节 Adjustable Steering Wheel
        ///</summary>
        public string AdjustableSW { get; set; }

        ///<summary>
        ///方向盘电动调节
        ///</summary>
        public string ElecAdjustableSW { get; set; }

        ///<summary>
        ///多功能方向盘 Multifunction Steering Wheel
        ///</summary>
        public string MultifunctionSW { get; set; }

        ///<summary>
        ///方向盘换挡
        ///</summary>
        public string SWShift { get; set; }

        ///<summary>
        ///方向盘加热
        ///</summary>
        public string SWHeat { get; set; }


        ///<summary>
        ///方向盘记忆
        ///</summary>
        public string SWMemory { get; set; }

        ///<summary>
        ///行车电脑显示屏
        ///</summary>
        public string ComputerDisplayScreen { get; set; }

        ///<summary>
        ///全液晶仪表盘
        ///</summary>
        public string FullLCDDashboard { get; set; }

        ///<summary>
        ///HUD抬头数字显示
        ///</summary>
        public string HUD { get; set; }

        ///<summary>
        ///座椅材质
        ///</summary>
        public string SeatMaterial { get; set; }

        ///<summary>
        ///运动风格座椅
        ///</summary>
        public string SportSeat { get; set; }

        ///<summary>
        ///座椅高低调节
        ///</summary>
        public string SeatHeightAdjust { get; set; }

        ///<summary>
        ///腰部支撑调节
        ///</summary>
        public string SeatLumbarAdjust { get; set; }

        ///<summary>
        ///肩部支撑调节
        ///</summary>
        public string SeatShoulderAdjust { get; set; }

        ///<summary>
        ///主驾驶座电动调节
        ///</summary>
        public string SeatDriverElectAdjust { get; set; }

        ///<summary>
        ///副驾驶座电动调节
        ///</summary>
        public string SeatPassengerElectAdjust { get; set; }

        ///<summary>
        ///第二排靠背角度调节
        ///</summary>
        public string SecondRowBackAngleAdjust { get; set; }

        ///<summary>
        ///第二排座椅移动
        ///</summary>
        public string SecondRowSeatMove { get; set; }

        ///<summary>
        ///后排座椅电动调节
        ///</summary>
        public string RearSeatElectAdjust { get; set; }

        ///<summary>
        ///电动座椅记忆
        ///</summary>
        public string ElecSeatMemory { get; set; }

        ///<summary>
        ///前排座椅加热
        ///</summary>
        public string FrontSeatHeat { get; set; }

        ///<summary>
        ///后排座椅加热
        ///</summary>
        public string RearSeatHeat { get; set; }

        /// <summary>
        /// 前排座椅通风
        /// </summary>
        public string FrontSeatVentilate { get; set; }

        /// <summary>
        /// 后排座椅通风
        /// </summary>
        public string RearSeatVentilate { get; set; }

        /// <summary>
        /// 前排座椅按摩
        /// </summary>
        public string FrontSeatMassage { get; set; }

        /// <summary>
        /// 后排座椅按摩
        /// </summary>
        public string RearSeatMassage { get; set; }

        /// <summary>
        /// 第三排座椅
        /// </summary>
        public string ThirdRowSeat { get; set; }

        /// <summary>
        /// 后排座椅放倒方式 
        /// </summary>
        public string RearSeatDownWay { get; set; }

        /// <summary>
        /// 前中央扶手
        /// </summary>
        public string FrontCentralArmrest { get; set; }

        /// <summary>
        /// 后中央扶手
        /// </summary>
        public string RearCentralArmrest { get; set; }

        /// <summary>
        /// 后排杯架
        /// </summary>
        public string RearCupShelf { get; set; }


        /// <summary>
        /// GPS定位
        /// </summary>
        public string GPS { get; set; }

        /// <summary>
        /// 定位互动服务
        /// </summary>
        public string Localization { get; set; }

        /// <summary>
        /// 中控台彩色大屏
        /// </summary>
        public string CentralColorScreen { get; set; }

        ///<summary>
        ///中控液晶分屏显示
        ///</summary>
        public string CentralScreenSplitDisplay { get; set; }

        /// <summary>
        /// 蓝牙/车载电话
        /// </summary>
        public string BTA { get; set; }

        /// <summary>
        /// 车载电视
        /// </summary>
        public string TV { get; set; }

        /// <summary>
        /// 后排液晶屏
        /// </summary>
        public string RearLCDScreen { get; set; }

        /// <summary>
        /// 220V/230V电源
        /// </summary>
        public string PowerSource { get; set; }

        ///<summary>
        ///CD/DVD
        ///</summary>
        public string DVD { get; set; }

        /// <summary>
        /// 扬声器品牌 <>
        /// </summary>
        public string SpeakerBrand { get; set; }

        /// <summary>
        /// 扬声器数量
        /// </summary>
        public string SpeakerNo { get; set; }


        /// <summary>
        /// 近光灯 
        /// </summary>
        public string LowBeam { get; set; }

        /// <summary>
        /// 远光灯 
        /// </summary>
        public string HighBeam { get; set; }

        /// <summary>
        /// 日间行车灯 Daytime Running Light
        /// </summary>
        public string DRL { get; set; }

        /// <summary>
        /// 自适应远近光
        /// </summary>
        public string AdaptiveHighLow { get; set; }

        /// <summary>
        /// 自动头灯
        /// </summary>
        public string AutoLight { get; set; }

        /// <summary>
        /// 转向辅助灯
        /// </summary>
        public string SteeringAssistLamp { get; set; }

        /// <summary>
        /// 转向头灯
        /// </summary>
        public string AFS { get; set; }
        /// <summary>
        /// 前雾灯
        /// </summary>
        public string FrontFogLamp { get; set; }

        /// <summary>
        /// 大灯高度可调
        /// </summary>
        public string HeadLightAdjustable { get; set; }

        /// <summary>
        /// 大灯清洗装置
        /// </summary>
        public string SRA { get; set; }

        /// <summary>
        /// 车内氛围灯
        /// </summary>
        public string AmbientLight { get; set; }

        /// <summary>
        /// 前电动车窗
        /// </summary>
        public string FrontElecWindow { get; set; }

        /// <summary>
        /// 后电动车窗
        /// </summary>
        public string RearElecWindow { get; set; }


        /// <summary>
        /// 车窗防夹手功能
        /// </summary>
        public string AntiPinchWindow { get; set; }

        /// <summary>
        /// 防紫外线/隔热玻璃
        /// </summary>
        public string AntiUVInsulatingGlass { get; set; }


        /// <summary>
        /// 后视镜电动调节
        /// </summary>
        public string RearViewMirrorAdjustable { get; set; }

        /// <summary>
        /// 后视镜加热
        /// </summary>
        public string MirrorHeat { get; set; }

        /// <summary>
        /// 内后视镜自动防眩目
        /// </summary>
        public string InnerMirrorAutoDimming { get; set; }

        /// <summary>
        /// 外后视镜自动防眩目
        /// </summary>
        public string OuterMirrorAutoDimming { get; set; }


        /// <summary>
        /// 后视镜电动折叠
        /// </summary>
        public string MirrorElecFold { get; set; }

        /// <summary>
        /// 后视镜记忆
        /// </summary>
        public string MirrorMemory { get; set; }

        /// <summary>
        /// 后风挡遮阳帘
        /// </summary>
        public string RearWindowSunshade { get; set; }

        /// <summary>
        /// 后排侧遮阳帘
        /// </summary>
        public string RearSideSunshade { get; set; }

        /// <summary>
        /// 后排侧隐私玻璃
        /// </summary>
        public string RearPrivacyGlass { get; set; }

        /// <summary>
        /// 遮阳板化妆镜
        /// </summary>
        public string SunVisor { get; set; }

        /// <summary>
        /// 后雨刷
        /// </summary>
        public string RearWiper { get; set; }

        /// <summary>
        /// 感应雨刷
        /// </summary>
        public string SensingWiper { get; set; }


        /// <summary>
        /// 空调控制方式
        /// </summary>
        public string AirControl { get; set; }

        /// <summary>
        /// 后排独立空调
        /// </summary>
        public string RearAir { get; set; }

        /// <summary>
        /// 后座出风口
        /// </summary>
        public string BackWindOutlet { get; set; }

        /// <summary>
        /// 温度分区控制
        /// </summary>
        public string TempControlRespective { get; set; }

        /// <summary>
        /// 车内空气调节/花粉过滤
        /// </summary>
        public string PollenFilter { get; set; }

        /// <summary>
        /// 车载冰箱
        /// </summary>
        public string Refrigerator { get; set; }


        public int YearId { get; set; }

        public virtual Year Year { get; set; }


        public int SerieId { get; set; }

        public virtual Serie Serie { get; set; }


        ///<summary>
        ///外观颜色
        ///</summary>
        public ICollection<Color> Colors = new List<Color>();

        ///<summary>
        ///内饰颜色
        ///</summary>
        public ICollection<InnerColor> InnerColors = new List<InnerColor>();
    }
}
