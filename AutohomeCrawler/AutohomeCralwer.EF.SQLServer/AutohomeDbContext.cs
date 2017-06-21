using System;
using AutohomeCralwer.EF.SQLServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutohomeCralwer.EF.SQLServer
{
    public class AutohomeDbContext : DbContext
    {
        public AutohomeDbContext(DbContextOptions<AutohomeDbContext> options) : base(options)
        {
        }


        public DbSet<Brand> Brands { get; set; }

        public DbSet<Factory> Factories { get; set; }

        public DbSet<Serie> Series { get; set; }

        public DbSet<Year> Years { get; set; }

        public DbSet<CarType> CarTypes { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<InnerColor> InnerColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>(b =>
            {
                b.ToTable(TableNames.Brands);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.PinYin).HasMaxLength(50);
                b.Property(t => t.FirstLetter).HasMaxLength(1);
            });

            modelBuilder.Entity<Factory>(b =>
            {
                b.ToTable(TableNames.Factories);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.FirstLetter).HasMaxLength(1);

                b.HasOne(t => t.Brand).WithMany(t => t.Factories).HasForeignKey(t => t.BrandId);
            });

            modelBuilder.Entity<Serie>(b =>
            {
                b.ToTable(TableNames.Series);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.FirstLetter).HasMaxLength(1);

                b.HasOne(t => t.Factory).WithMany(t => t.Series).HasForeignKey(t => t.FactoryId);
                b.HasOne(t => t.Brand).WithMany(t => t.Series).HasForeignKey(t => t.BrandId);
            });

            modelBuilder.Entity<Year>(b =>
            {
                b.ToTable(TableNames.Years);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(25);

                b.HasOne(t => t.Serie).WithMany(t => t.Years).HasForeignKey(t => t.SerieId);
            });


            modelBuilder.Entity<CarType>(b =>
            {
                b.ToTable(TableNames.CarTypes);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.MSRP).HasMaxLength(20);
                b.Property(t => t.DRP).HasMaxLength(20);
                b.Property(t => t.Level).HasMaxLength(20);
                b.Property(t => t.MaxSpeed).HasMaxLength(20);
                b.Property(t => t.OfficialAcc).HasMaxLength(20);
                b.Property(t => t.Factory).HasMaxLength(50);

                b.Property(t => t.FactAcc).HasMaxLength(20);
                b.Property(t => t.FactBrake).HasMaxLength(20);
                b.Property(t => t.FactFuelConsumption).HasMaxLength(20);
                b.Property(t => t.DepFuelConsumption).HasMaxLength(20);
                b.Property(t => t.BasicWarranty).HasMaxLength(20);

                b.Property(t => t.Length).HasMaxLength(20);
                b.Property(t => t.Width).HasMaxLength(20);
                b.Property(t => t.Height).HasMaxLength(20);
                b.Property(t => t.Wheelbase).HasMaxLength(20);
                b.Property(t => t.FrontTrack).HasMaxLength(20);

                b.Property(t => t.RearTrack).HasMaxLength(20);
                b.Property(t => t.GroundClearance).HasMaxLength(20);
                b.Property(t => t.CurbWeight).HasMaxLength(20);
                b.Property(t => t.BodyShellStruct).HasMaxLength(20);
                b.Property(t => t.CargoCapacity).HasMaxLength(20);

                b.Property(t => t.FuelTankCapacity).HasMaxLength(20);
                b.Property(t => t.TotalDoor).HasMaxLength(20);
                b.Property(t => t.TotalSeating).HasMaxLength(20);
                b.Property(t => t.EngineType).HasMaxLength(20);
                b.Property(t => t.DisplacementML).HasMaxLength(20);

                b.Property(t => t.Displacement).HasMaxLength(20);
                b.Property(t => t.AirInForm).HasMaxLength(20);
                b.Property(t => t.CylinderArrangement).HasMaxLength(20);
                b.Property(t => t.CylinderNo).HasMaxLength(20);
                b.Property(t => t.ValveNoPerCylinder).HasMaxLength(20);

                b.Property(t => t.CompressRatio).HasMaxLength(20);
                b.Property(t => t.ValveMechanism).HasMaxLength(20);
                b.Property(t => t.CylinderDiameter).HasMaxLength(20);
                b.Property(t => t.Stroke).HasMaxLength(20);
                b.Property(t => t.Horsepower).HasMaxLength(20);

                b.Property(t => t.Power).HasMaxLength(20);
                b.Property(t => t.PowerRevolvingSpeed).HasMaxLength(20);
                b.Property(t => t.Torque).HasMaxLength(20);
                b.Property(t => t.TorqueRevolvingSpeed).HasMaxLength(20);
                b.Property(t => t.EngineSpecialTech).HasMaxLength(20);

                b.Property(t => t.FuelType).HasMaxLength(20);
                b.Property(t => t.FuelLabel).HasMaxLength(20);
                b.Property(t => t.FuelSupply).HasMaxLength(20);
                b.Property(t => t.CylinderHeadMaterial).HasMaxLength(20);
                b.Property(t => t.CylinderBodyMaterial).HasMaxLength(20);

                b.Property(t => t.EnvStandard).HasMaxLength(20);
                b.Property(t => t.GearBox).HasMaxLength(20);
                b.Property(t => t.GearsNo).HasMaxLength(20);
                b.Property(t => t.GearBoxType).HasMaxLength(20);
                b.Property(t => t.DriveType).HasMaxLength(20);

                b.Property(t => t.FrontSuspension).HasMaxLength(20);
                b.Property(t => t.RearSuspension).HasMaxLength(20);
                b.Property(t => t.PowerType).HasMaxLength(20);
                b.Property(t => t.BodyStructure).HasMaxLength(20);
                b.Property(t => t.FrontBrake).HasMaxLength(20);

                b.Property(t => t.RearBrake).HasMaxLength(20);
                b.Property(t => t.FrontTire).HasMaxLength(20);
                b.Property(t => t.RearTire).HasMaxLength(20);
                b.Property(t => t.SpareTire).HasMaxLength(20);
                b.Property(t => t.DriverAirBag).HasMaxLength(20);

                b.Property(t => t.PassengerAirBag).HasMaxLength(20);
                b.Property(t => t.FrontSideAirBag).HasMaxLength(20);
                b.Property(t => t.RearSideAirBag).HasMaxLength(20);
                b.Property(t => t.FrontHeadAirBag).HasMaxLength(20);
                b.Property(t => t.RearHeadAirBag).HasMaxLength(20);

                b.Property(t => t.KneeAirBag).HasMaxLength(20);
                b.Property(t => t.TPMS).HasMaxLength(20);
                b.Property(t => t.ZeroTirePressure).HasMaxLength(20);
                b.Property(t => t.SeatBeltPrompt).HasMaxLength(20);
                b.Property(t => t.ISOFIX).HasMaxLength(20);

                b.Property(t => t.ABS).HasMaxLength(20);
                b.Property(t => t.EBD).HasMaxLength(20);
                b.Property(t => t.EBA).HasMaxLength(20);
                b.Property(t => t.MASR).HasMaxLength(20);
                b.Property(t => t.ESC).HasMaxLength(20);

                b.Property(t => t.SideAssist).HasMaxLength(20);
                b.Property(t => t.LWDS).HasMaxLength(20);
                b.Property(t => t.ActiveBrakeAssist).HasMaxLength(20);
                b.Property(t => t.NVA).HasMaxLength(20);
                b.Property(t => t.FrontParkRadar).HasMaxLength(20);

                b.Property(t => t.PanoramicCamera).HasMaxLength(20);
                b.Property(t => t.CruiseControl).HasMaxLength(20);
                b.Property(t => t.ACC).HasMaxLength(20);
                b.Property(t => t.ParkAssistVision).HasMaxLength(20);
                b.Property(t => t.EngineStartStop).HasMaxLength(20);

                b.Property(t => t.HAC).HasMaxLength(20);
                b.Property(t => t.AutoHold).HasMaxLength(20);
                b.Property(t => t.HDC).HasMaxLength(20);
                b.Property(t => t.AVS).HasMaxLength(20);
                b.Property(t => t.AirSuspension).HasMaxLength(20);

                b.Property(t => t.VGRS).HasMaxLength(20);
                b.Property(t => t.FrontDifferential).HasMaxLength(20);
                b.Property(t => t.CentralDifferential).HasMaxLength(20);
                b.Property(t => t.RearDifferential).HasMaxLength(20);
                b.Property(t => t.IntegralActiveSteering).HasMaxLength(20);

                b.Property(t => t.PowerSunroof).HasMaxLength(20);
                b.Property(t => t.PanoramicSunroof).HasMaxLength(20);
                b.Property(t => t.SportPackage).HasMaxLength(20);
                b.Property(t => t.LumminumRim).HasMaxLength(20);
                b.Property(t => t.ElecSuctionDoor).HasMaxLength(20);

                b.Property(t => t.SideSlidingDoor).HasMaxLength(20);
                b.Property(t => t.ElecTrunk).HasMaxLength(20);
                b.Property(t => t.SensingTrunk).HasMaxLength(20);
                b.Property(t => t.RoofRack).HasMaxLength(20);
                b.Property(t => t.IMMO).HasMaxLength(20);

                b.Property(t => t.CentralLocking).HasMaxLength(20);
                b.Property(t => t.RKE).HasMaxLength(20);
                b.Property(t => t.PEPS).HasMaxLength(20);
                b.Property(t => t.PKE).HasMaxLength(20);
                b.Property(t => t.LeatherSW).HasMaxLength(20);

                b.Property(t => t.AdjustableSW).HasMaxLength(20);
                b.Property(t => t.ElecAdjustableSW).HasMaxLength(20);
                b.Property(t => t.MultifunctionSW).HasMaxLength(20);
                b.Property(t => t.SWShift).HasMaxLength(20);
                b.Property(t => t.SWHeat).HasMaxLength(20);

                b.Property(t => t.SWMemory).HasMaxLength(20);
                b.Property(t => t.ComputerDisplayScreen).HasMaxLength(20);
                b.Property(t => t.FullLCDDashboard).HasMaxLength(20);
                b.Property(t => t.HUD).HasMaxLength(20);
                b.Property(t => t.SeatMaterial).HasMaxLength(20);

                b.Property(t => t.SportSeat).HasMaxLength(20);
                b.Property(t => t.SeatHeightAdjust).HasMaxLength(20);
                b.Property(t => t.SeatLumbarAdjust).HasMaxLength(20);
                b.Property(t => t.SeatShoulderAdjust).HasMaxLength(20);
                b.Property(t => t.SeatDriverElectAdjust).HasMaxLength(20);

                b.Property(t => t.SeatDriverElectAdjust).HasMaxLength(20);
                b.Property(t => t.SeatPassengerElectAdjust).HasMaxLength(20);
                b.Property(t => t.SecondRowBackAngleAdjust).HasMaxLength(20);
                b.Property(t => t.SecondRowSeatMove).HasMaxLength(20);
                b.Property(t => t.RearSeatElectAdjust).HasMaxLength(20);
                b.Property(t => t.ElecSeatMemory).HasMaxLength(20);

                b.Property(t => t.FrontSeatHeat).HasMaxLength(20);
                b.Property(t => t.RearSeatHeat).HasMaxLength(20);
                b.Property(t => t.FrontSeatVentilate).HasMaxLength(20);
                b.Property(t => t.RearSeatVentilate).HasMaxLength(20);
                b.Property(t => t.FrontSeatMassage).HasMaxLength(20);

                b.Property(t => t.RearSeatMassage).HasMaxLength(20);
                b.Property(t => t.ThirdRowSeat).HasMaxLength(20);
                b.Property(t => t.RearSeatDownWay).HasMaxLength(20);
                b.Property(t => t.FrontCentralArmrest).HasMaxLength(20);
                b.Property(t => t.RearCentralArmrest).HasMaxLength(20);

                b.Property(t => t.RearCupShelf).HasMaxLength(20);
                b.Property(t => t.GPS).HasMaxLength(20);
                b.Property(t => t.Localization).HasMaxLength(20);
                b.Property(t => t.CentralColorScreen).HasMaxLength(20);
                b.Property(t => t.CentralScreenSplitDisplay).HasMaxLength(20);

                b.Property(t => t.BTA).HasMaxLength(20);
                b.Property(t => t.TV).HasMaxLength(20);
                b.Property(t => t.RearLCDScreen).HasMaxLength(20);
                b.Property(t => t.PowerSource).HasMaxLength(20);
                b.Property(t => t.DVD).HasMaxLength(20);

                b.Property(t => t.SpeakerBrand).HasMaxLength(20);
                b.Property(t => t.SpeakerNo).HasMaxLength(20);
                b.Property(t => t.LowBeam).HasMaxLength(20);
                b.Property(t => t.HighBeam).HasMaxLength(20);
                b.Property(t => t.DRL).HasMaxLength(20);

                b.Property(t => t.AdaptiveHighLow).HasMaxLength(20);
                b.Property(t => t.AutoLight).HasMaxLength(20);
                b.Property(t => t.SteeringAssistLamp).HasMaxLength(20);
                b.Property(t => t.AFS).HasMaxLength(20);
                b.Property(t => t.FrontFogLamp).HasMaxLength(20);

                b.Property(t => t.HeadLightAdjustable).HasMaxLength(20);
                b.Property(t => t.SRA).HasMaxLength(20);
                b.Property(t => t.AmbientLight).HasMaxLength(20);
                b.Property(t => t.FrontElecWindow).HasMaxLength(20);
                b.Property(t => t.RearSeatElectAdjust).HasMaxLength(20);

                b.Property(t => t.AntiPinchWindow).HasMaxLength(20);
                b.Property(t => t.AntiUVInsulatingGlass).HasMaxLength(20);
                b.Property(t => t.RearViewMirrorAdjustable).HasMaxLength(20);
                b.Property(t => t.MirrorHeat).HasMaxLength(20);
                b.Property(t => t.InnerMirrorAutoDimming).HasMaxLength(20);

                b.Property(t => t.OuterMirrorAutoDimming).HasMaxLength(20);
                b.Property(t => t.MirrorElecFold).HasMaxLength(20);
                b.Property(t => t.MirrorMemory).HasMaxLength(20);
                b.Property(t => t.RearWindowSunshade).HasMaxLength(20);
                b.Property(t => t.RearSideSunshade).HasMaxLength(20);

                b.Property(t => t.RearPrivacyGlass).HasMaxLength(20);
                b.Property(t => t.SunVisor).HasMaxLength(20);
                b.Property(t => t.RearWiper).HasMaxLength(20);
                b.Property(t => t.SensingWiper).HasMaxLength(20);
                b.Property(t => t.AirControl).HasMaxLength(20);

                b.Property(t => t.RearAir).HasMaxLength(20);
                b.Property(t => t.BackWindOutlet).HasMaxLength(20);
                b.Property(t => t.TempControlRespective).HasMaxLength(20);
                b.Property(t => t.PollenFilter).HasMaxLength(20);
                b.Property(t => t.Refrigerator).HasMaxLength(20);


                b.HasOne(t => t.Year).WithMany(t => t.CarTypes).HasForeignKey(t => t.YearId);
                b.HasOne(t => t.Serie).WithMany(t => t.CarTypes).HasForeignKey(t => t.SerieId);

            });


            modelBuilder.Entity<Color>(b =>
            {
                b.ToTable(TableNames.Colors);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.Value).HasMaxLength(50);

                b.HasOne(t => t.CarType).WithMany(t => t.Colors).HasForeignKey(t => t.CarTypeId);
            });


            modelBuilder.Entity<InnerColor>(b =>
            {
                b.ToTable(TableNames.InnerColors);
                b.HasKey(t => t.Id);
                b.Property(t => t.Id).ValueGeneratedNever();

                b.Property(t => t.Name).HasMaxLength(50);
                b.Property(t => t.Value).HasMaxLength(50);

                b.HasOne(t => t.CarType).WithMany(t => t.InnerColors).HasForeignKey(t => t.CarTypeId);
            });
        }
    }
}
