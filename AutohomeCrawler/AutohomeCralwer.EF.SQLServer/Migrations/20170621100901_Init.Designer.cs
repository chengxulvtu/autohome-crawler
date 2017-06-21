using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AutohomeCralwer.EF.SQLServer;

namespace AutohomeCralwer.EF.SQLServer.Migrations
{
    [DbContext(typeof(AutohomeDbContext))]
    [Migration("20170621100901_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Brand", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FirstLetter")
                        .HasMaxLength(1);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("PinYin")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.CarType", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("ABS")
                        .HasMaxLength(20);

                    b.Property<string>("ACC")
                        .HasMaxLength(20);

                    b.Property<string>("AFS")
                        .HasMaxLength(20);

                    b.Property<string>("AVS")
                        .HasMaxLength(20);

                    b.Property<string>("ActiveBrakeAssist")
                        .HasMaxLength(20);

                    b.Property<string>("AdaptiveHighLow")
                        .HasMaxLength(20);

                    b.Property<string>("AdjustableSW")
                        .HasMaxLength(20);

                    b.Property<string>("AirControl")
                        .HasMaxLength(20);

                    b.Property<string>("AirInForm")
                        .HasMaxLength(20);

                    b.Property<string>("AirSuspension")
                        .HasMaxLength(20);

                    b.Property<string>("AmbientLight")
                        .HasMaxLength(20);

                    b.Property<string>("AntiPinchWindow")
                        .HasMaxLength(20);

                    b.Property<string>("AntiUVInsulatingGlass")
                        .HasMaxLength(20);

                    b.Property<string>("AutoHold")
                        .HasMaxLength(20);

                    b.Property<string>("AutoLight")
                        .HasMaxLength(20);

                    b.Property<string>("BTA")
                        .HasMaxLength(20);

                    b.Property<string>("BackWindOutlet")
                        .HasMaxLength(20);

                    b.Property<string>("BasicWarranty")
                        .HasMaxLength(20);

                    b.Property<string>("BodyShellStruct")
                        .HasMaxLength(20);

                    b.Property<string>("BodyStructure")
                        .HasMaxLength(20);

                    b.Property<string>("CargoCapacity")
                        .HasMaxLength(20);

                    b.Property<string>("CentralColorScreen")
                        .HasMaxLength(20);

                    b.Property<string>("CentralDifferential")
                        .HasMaxLength(20);

                    b.Property<string>("CentralLocking")
                        .HasMaxLength(20);

                    b.Property<string>("CentralScreenSplitDisplay")
                        .HasMaxLength(20);

                    b.Property<string>("CompressRatio")
                        .HasMaxLength(20);

                    b.Property<string>("ComputerDisplayScreen")
                        .HasMaxLength(20);

                    b.Property<string>("CruiseControl")
                        .HasMaxLength(20);

                    b.Property<string>("CurbWeight")
                        .HasMaxLength(20);

                    b.Property<string>("CylinderArrangement")
                        .HasMaxLength(20);

                    b.Property<string>("CylinderBodyMaterial")
                        .HasMaxLength(20);

                    b.Property<string>("CylinderDiameter")
                        .HasMaxLength(20);

                    b.Property<string>("CylinderHeadMaterial")
                        .HasMaxLength(20);

                    b.Property<string>("CylinderNo")
                        .HasMaxLength(20);

                    b.Property<string>("DRL")
                        .HasMaxLength(20);

                    b.Property<string>("DRP")
                        .HasMaxLength(20);

                    b.Property<string>("DVD")
                        .HasMaxLength(20);

                    b.Property<string>("DepFuelConsumption")
                        .HasMaxLength(20);

                    b.Property<string>("Displacement")
                        .HasMaxLength(20);

                    b.Property<string>("DisplacementML")
                        .HasMaxLength(20);

                    b.Property<string>("DriveType")
                        .HasMaxLength(20);

                    b.Property<string>("DriverAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("EBA")
                        .HasMaxLength(20);

                    b.Property<string>("EBD")
                        .HasMaxLength(20);

                    b.Property<string>("ESC")
                        .HasMaxLength(20);

                    b.Property<string>("ElecAdjustableSW")
                        .HasMaxLength(20);

                    b.Property<string>("ElecSeatMemory")
                        .HasMaxLength(20);

                    b.Property<string>("ElecSuctionDoor")
                        .HasMaxLength(20);

                    b.Property<string>("ElecTrunk")
                        .HasMaxLength(20);

                    b.Property<string>("EngineSpecialTech")
                        .HasMaxLength(20);

                    b.Property<string>("EngineStartStop")
                        .HasMaxLength(20);

                    b.Property<string>("EngineType")
                        .HasMaxLength(20);

                    b.Property<string>("EnvStandard")
                        .HasMaxLength(20);

                    b.Property<string>("FactAcc")
                        .HasMaxLength(20);

                    b.Property<string>("FactBrake")
                        .HasMaxLength(20);

                    b.Property<string>("FactFuelConsumption")
                        .HasMaxLength(20);

                    b.Property<string>("FactGroundClearance");

                    b.Property<string>("Factory")
                        .HasMaxLength(50);

                    b.Property<string>("FrontBrake")
                        .HasMaxLength(20);

                    b.Property<string>("FrontCentralArmrest")
                        .HasMaxLength(20);

                    b.Property<string>("FrontDifferential")
                        .HasMaxLength(20);

                    b.Property<string>("FrontElecWindow")
                        .HasMaxLength(20);

                    b.Property<string>("FrontFogLamp")
                        .HasMaxLength(20);

                    b.Property<string>("FrontHeadAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("FrontParkRadar")
                        .HasMaxLength(20);

                    b.Property<string>("FrontSeatHeat")
                        .HasMaxLength(20);

                    b.Property<string>("FrontSeatMassage")
                        .HasMaxLength(20);

                    b.Property<string>("FrontSeatVentilate")
                        .HasMaxLength(20);

                    b.Property<string>("FrontSideAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("FrontSuspension")
                        .HasMaxLength(20);

                    b.Property<string>("FrontTire")
                        .HasMaxLength(20);

                    b.Property<string>("FrontTrack")
                        .HasMaxLength(20);

                    b.Property<string>("FuelLabel")
                        .HasMaxLength(20);

                    b.Property<string>("FuelSupply")
                        .HasMaxLength(20);

                    b.Property<string>("FuelTankCapacity")
                        .HasMaxLength(20);

                    b.Property<string>("FuelType")
                        .HasMaxLength(20);

                    b.Property<string>("FullLCDDashboard")
                        .HasMaxLength(20);

                    b.Property<string>("GPS")
                        .HasMaxLength(20);

                    b.Property<string>("GearBox")
                        .HasMaxLength(20);

                    b.Property<string>("GearBoxType")
                        .HasMaxLength(20);

                    b.Property<string>("GearsNo")
                        .HasMaxLength(20);

                    b.Property<string>("GroundClearance")
                        .HasMaxLength(20);

                    b.Property<string>("HAC")
                        .HasMaxLength(20);

                    b.Property<string>("HDC")
                        .HasMaxLength(20);

                    b.Property<string>("HUD")
                        .HasMaxLength(20);

                    b.Property<string>("HeadLightAdjustable")
                        .HasMaxLength(20);

                    b.Property<string>("Height")
                        .HasMaxLength(20);

                    b.Property<string>("HighBeam")
                        .HasMaxLength(20);

                    b.Property<string>("Horsepower")
                        .HasMaxLength(20);

                    b.Property<string>("IMMO")
                        .HasMaxLength(20);

                    b.Property<string>("ISOFIX")
                        .HasMaxLength(20);

                    b.Property<string>("InnerMirrorAutoDimming")
                        .HasMaxLength(20);

                    b.Property<string>("IntegralActiveSteering")
                        .HasMaxLength(20);

                    b.Property<string>("KneeAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("LWDS")
                        .HasMaxLength(20);

                    b.Property<string>("LeatherSW")
                        .HasMaxLength(20);

                    b.Property<string>("Length")
                        .HasMaxLength(20);

                    b.Property<string>("Level")
                        .HasMaxLength(20);

                    b.Property<string>("Localization")
                        .HasMaxLength(20);

                    b.Property<string>("LowBeam")
                        .HasMaxLength(20);

                    b.Property<string>("LumminumRim")
                        .HasMaxLength(20);

                    b.Property<string>("MASR")
                        .HasMaxLength(20);

                    b.Property<string>("MSRP")
                        .HasMaxLength(20);

                    b.Property<string>("MaxSpeed")
                        .HasMaxLength(20);

                    b.Property<string>("MirrorElecFold")
                        .HasMaxLength(20);

                    b.Property<string>("MirrorHeat")
                        .HasMaxLength(20);

                    b.Property<string>("MirrorMemory")
                        .HasMaxLength(20);

                    b.Property<string>("MultifunctionSW")
                        .HasMaxLength(20);

                    b.Property<string>("NVA")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("OfficialAcc")
                        .HasMaxLength(20);

                    b.Property<string>("OuterMirrorAutoDimming")
                        .HasMaxLength(20);

                    b.Property<string>("PEPS")
                        .HasMaxLength(20);

                    b.Property<string>("PKE")
                        .HasMaxLength(20);

                    b.Property<string>("PanoramicCamera")
                        .HasMaxLength(20);

                    b.Property<string>("PanoramicSunroof")
                        .HasMaxLength(20);

                    b.Property<string>("ParkAssistVision")
                        .HasMaxLength(20);

                    b.Property<string>("ParkBrake");

                    b.Property<string>("PassengerAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("PollenFilter")
                        .HasMaxLength(20);

                    b.Property<string>("Power")
                        .HasMaxLength(20);

                    b.Property<string>("PowerRevolvingSpeed")
                        .HasMaxLength(20);

                    b.Property<string>("PowerSource")
                        .HasMaxLength(20);

                    b.Property<string>("PowerSunroof")
                        .HasMaxLength(20);

                    b.Property<string>("PowerType")
                        .HasMaxLength(20);

                    b.Property<string>("RKE")
                        .HasMaxLength(20);

                    b.Property<string>("RearAir")
                        .HasMaxLength(20);

                    b.Property<string>("RearBrake")
                        .HasMaxLength(20);

                    b.Property<string>("RearCentralArmrest")
                        .HasMaxLength(20);

                    b.Property<string>("RearCupShelf")
                        .HasMaxLength(20);

                    b.Property<string>("RearDifferential")
                        .HasMaxLength(20);

                    b.Property<string>("RearElecWindow");

                    b.Property<string>("RearHeadAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("RearLCDScreen")
                        .HasMaxLength(20);

                    b.Property<string>("RearParkRadar");

                    b.Property<string>("RearPrivacyGlass")
                        .HasMaxLength(20);

                    b.Property<string>("RearSeatDownWay")
                        .HasMaxLength(20);

                    b.Property<string>("RearSeatElectAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("RearSeatHeat")
                        .HasMaxLength(20);

                    b.Property<string>("RearSeatMassage")
                        .HasMaxLength(20);

                    b.Property<string>("RearSeatVentilate")
                        .HasMaxLength(20);

                    b.Property<string>("RearSideAirBag")
                        .HasMaxLength(20);

                    b.Property<string>("RearSideSunshade")
                        .HasMaxLength(20);

                    b.Property<string>("RearSuspension")
                        .HasMaxLength(20);

                    b.Property<string>("RearTire")
                        .HasMaxLength(20);

                    b.Property<string>("RearTrack")
                        .HasMaxLength(20);

                    b.Property<string>("RearViewMirrorAdjustable")
                        .HasMaxLength(20);

                    b.Property<string>("RearWindowSunshade")
                        .HasMaxLength(20);

                    b.Property<string>("RearWiper")
                        .HasMaxLength(20);

                    b.Property<string>("Refrigerator")
                        .HasMaxLength(20);

                    b.Property<string>("RoofRack")
                        .HasMaxLength(20);

                    b.Property<string>("SRA")
                        .HasMaxLength(20);

                    b.Property<string>("SWHeat")
                        .HasMaxLength(20);

                    b.Property<string>("SWMemory")
                        .HasMaxLength(20);

                    b.Property<string>("SWShift")
                        .HasMaxLength(20);

                    b.Property<string>("SeatBeltPrompt")
                        .HasMaxLength(20);

                    b.Property<string>("SeatDriverElectAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SeatHeightAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SeatLumbarAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SeatMaterial")
                        .HasMaxLength(20);

                    b.Property<string>("SeatPassengerElectAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SeatShoulderAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SecondRowBackAngleAdjust")
                        .HasMaxLength(20);

                    b.Property<string>("SecondRowSeatMove")
                        .HasMaxLength(20);

                    b.Property<string>("SensingTrunk")
                        .HasMaxLength(20);

                    b.Property<string>("SensingWiper")
                        .HasMaxLength(20);

                    b.Property<int>("SerieId");

                    b.Property<string>("SideAssist")
                        .HasMaxLength(20);

                    b.Property<string>("SideSlidingDoor")
                        .HasMaxLength(20);

                    b.Property<string>("SpareTire")
                        .HasMaxLength(20);

                    b.Property<string>("SpeakerBrand")
                        .HasMaxLength(20);

                    b.Property<string>("SpeakerNo")
                        .HasMaxLength(20);

                    b.Property<string>("SportPackage")
                        .HasMaxLength(20);

                    b.Property<string>("SportSeat")
                        .HasMaxLength(20);

                    b.Property<string>("SteeringAssistLamp")
                        .HasMaxLength(20);

                    b.Property<string>("Stroke")
                        .HasMaxLength(20);

                    b.Property<string>("SunVisor")
                        .HasMaxLength(20);

                    b.Property<string>("TPMS")
                        .HasMaxLength(20);

                    b.Property<string>("TV")
                        .HasMaxLength(20);

                    b.Property<string>("TempControlRespective")
                        .HasMaxLength(20);

                    b.Property<string>("ThirdRowSeat")
                        .HasMaxLength(20);

                    b.Property<string>("Torque")
                        .HasMaxLength(20);

                    b.Property<string>("TorqueRevolvingSpeed")
                        .HasMaxLength(20);

                    b.Property<string>("TotalDoor")
                        .HasMaxLength(20);

                    b.Property<string>("TotalSeating")
                        .HasMaxLength(20);

                    b.Property<string>("VGRS")
                        .HasMaxLength(20);

                    b.Property<string>("ValveMechanism")
                        .HasMaxLength(20);

                    b.Property<string>("ValveNoPerCylinder")
                        .HasMaxLength(20);

                    b.Property<string>("Wheelbase")
                        .HasMaxLength(20);

                    b.Property<string>("Width")
                        .HasMaxLength(20);

                    b.Property<int>("YearId");

                    b.Property<string>("ZeroTirePressure")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.HasIndex("YearId");

                    b.ToTable("CarTypes");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Color", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CarTypeId");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Value")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Factory", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("BrandId");

                    b.Property<string>("FirstLetter")
                        .HasMaxLength(1);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.InnerColor", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CarTypeId");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Value")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("InnerColors");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Serie", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("BrandId");

                    b.Property<int>("FactoryId");

                    b.Property<string>("FirstLetter")
                        .HasMaxLength(1);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("Order");

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("FactoryId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Year", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .HasMaxLength(25);

                    b.Property<int>("SerieId");

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.CarType", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Serie", "Serie")
                        .WithMany("CarTypes")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Year", "Year")
                        .WithMany("CarTypes")
                        .HasForeignKey("YearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Color", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.CarType", "CarType")
                        .WithMany("Colors")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Factory", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Brand", "Brand")
                        .WithMany("Factories")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.InnerColor", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.CarType", "CarType")
                        .WithMany("InnerColors")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Serie", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Brand", "Brand")
                        .WithMany("Series")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Factory", "Factory")
                        .WithMany("Series")
                        .HasForeignKey("FactoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Year", b =>
                {
                    b.HasOne("AutohomeCralwer.EF.SQLServer.Entities.Serie", "Serie")
                        .WithMany("Years")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
