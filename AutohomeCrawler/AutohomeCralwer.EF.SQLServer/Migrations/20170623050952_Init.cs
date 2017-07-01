using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutohomeCralwer.EF.SQLServer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FirstLetter = table.Column<string>(maxLength: 1, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    PinYin = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: false),
                    FirstLetter = table.Column<string>(maxLength: 1, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factories_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FactoryId = table.Column<int>(nullable: false),
                    FirstLetter = table.Column<string>(maxLength: 1, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Order = table.Column<int>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Series_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 25, nullable: true),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Years_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ABS = table.Column<string>(maxLength: 20, nullable: true),
                    ACC = table.Column<string>(maxLength: 20, nullable: true),
                    AFS = table.Column<string>(maxLength: 20, nullable: true),
                    AVS = table.Column<string>(maxLength: 20, nullable: true),
                    ActiveBrakeAssist = table.Column<string>(maxLength: 20, nullable: true),
                    AdaptiveHighLow = table.Column<string>(maxLength: 20, nullable: true),
                    AdjustableSW = table.Column<string>(maxLength: 20, nullable: true),
                    AirControl = table.Column<string>(maxLength: 20, nullable: true),
                    AirInForm = table.Column<string>(maxLength: 20, nullable: true),
                    AirSuspension = table.Column<string>(maxLength: 20, nullable: true),
                    AmbientLight = table.Column<string>(maxLength: 20, nullable: true),
                    AntiPinchWindow = table.Column<string>(maxLength: 20, nullable: true),
                    AntiUVInsulatingGlass = table.Column<string>(maxLength: 20, nullable: true),
                    AutoHold = table.Column<string>(maxLength: 20, nullable: true),
                    AutoLight = table.Column<string>(maxLength: 20, nullable: true),
                    BTA = table.Column<string>(maxLength: 20, nullable: true),
                    BackWindOutlet = table.Column<string>(maxLength: 20, nullable: true),
                    BasicWarranty = table.Column<string>(maxLength: 20, nullable: true),
                    BodyShellStruct = table.Column<string>(maxLength: 20, nullable: true),
                    BodyStructure = table.Column<string>(maxLength: 20, nullable: true),
                    CargoCapacity = table.Column<string>(maxLength: 20, nullable: true),
                    CentralColorScreen = table.Column<string>(maxLength: 20, nullable: true),
                    CentralDifferential = table.Column<string>(maxLength: 20, nullable: true),
                    CentralLocking = table.Column<string>(maxLength: 20, nullable: true),
                    CentralScreenSplitDisplay = table.Column<string>(maxLength: 20, nullable: true),
                    CompressRatio = table.Column<string>(maxLength: 20, nullable: true),
                    ComputerDisplayScreen = table.Column<string>(maxLength: 20, nullable: true),
                    CruiseControl = table.Column<string>(maxLength: 20, nullable: true),
                    CurbWeight = table.Column<string>(maxLength: 20, nullable: true),
                    CylinderArrangement = table.Column<string>(maxLength: 20, nullable: true),
                    CylinderBodyMaterial = table.Column<string>(maxLength: 20, nullable: true),
                    CylinderDiameter = table.Column<string>(maxLength: 20, nullable: true),
                    CylinderHeadMaterial = table.Column<string>(maxLength: 20, nullable: true),
                    CylinderNo = table.Column<string>(maxLength: 20, nullable: true),
                    DRL = table.Column<string>(maxLength: 20, nullable: true),
                    DRP = table.Column<string>(maxLength: 20, nullable: true),
                    DVD = table.Column<string>(maxLength: 20, nullable: true),
                    DepFuelConsumption = table.Column<string>(maxLength: 20, nullable: true),
                    Displacement = table.Column<string>(maxLength: 20, nullable: true),
                    DisplacementML = table.Column<string>(maxLength: 20, nullable: true),
                    DriveType = table.Column<string>(maxLength: 20, nullable: true),
                    DriverAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    EBA = table.Column<string>(maxLength: 20, nullable: true),
                    EBD = table.Column<string>(maxLength: 20, nullable: true),
                    ESC = table.Column<string>(maxLength: 20, nullable: true),
                    ElecAdjustableSW = table.Column<string>(maxLength: 20, nullable: true),
                    ElecSeatMemory = table.Column<string>(maxLength: 20, nullable: true),
                    ElecSuctionDoor = table.Column<string>(maxLength: 20, nullable: true),
                    ElecTrunk = table.Column<string>(maxLength: 20, nullable: true),
                    EngineSpecialTech = table.Column<string>(maxLength: 20, nullable: true),
                    EngineStartStop = table.Column<string>(maxLength: 20, nullable: true),
                    EngineType = table.Column<string>(maxLength: 20, nullable: true),
                    EnvStandard = table.Column<string>(maxLength: 20, nullable: true),
                    FactAcc = table.Column<string>(maxLength: 20, nullable: true),
                    FactBrake = table.Column<string>(maxLength: 20, nullable: true),
                    FactFuelConsumption = table.Column<string>(maxLength: 20, nullable: true),
                    FactGroundClearance = table.Column<string>(nullable: true),
                    Factory = table.Column<string>(maxLength: 50, nullable: true),
                    FrontBrake = table.Column<string>(maxLength: 20, nullable: true),
                    FrontCentralArmrest = table.Column<string>(maxLength: 20, nullable: true),
                    FrontDifferential = table.Column<string>(maxLength: 20, nullable: true),
                    FrontElecWindow = table.Column<string>(maxLength: 20, nullable: true),
                    FrontFogLamp = table.Column<string>(maxLength: 20, nullable: true),
                    FrontHeadAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    FrontParkRadar = table.Column<string>(maxLength: 20, nullable: true),
                    FrontSeatHeat = table.Column<string>(maxLength: 20, nullable: true),
                    FrontSeatMassage = table.Column<string>(maxLength: 20, nullable: true),
                    FrontSeatVentilate = table.Column<string>(maxLength: 20, nullable: true),
                    FrontSideAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    FrontSuspension = table.Column<string>(maxLength: 20, nullable: true),
                    FrontTire = table.Column<string>(maxLength: 20, nullable: true),
                    FrontTrack = table.Column<string>(maxLength: 20, nullable: true),
                    FuelLabel = table.Column<string>(maxLength: 20, nullable: true),
                    FuelSupply = table.Column<string>(maxLength: 20, nullable: true),
                    FuelTankCapacity = table.Column<string>(maxLength: 20, nullable: true),
                    FuelType = table.Column<string>(maxLength: 20, nullable: true),
                    FullLCDDashboard = table.Column<string>(maxLength: 20, nullable: true),
                    GPS = table.Column<string>(maxLength: 20, nullable: true),
                    GearBox = table.Column<string>(maxLength: 20, nullable: true),
                    GearBoxType = table.Column<string>(maxLength: 20, nullable: true),
                    GearsNo = table.Column<string>(maxLength: 20, nullable: true),
                    GroundClearance = table.Column<string>(maxLength: 20, nullable: true),
                    HAC = table.Column<string>(maxLength: 20, nullable: true),
                    HDC = table.Column<string>(maxLength: 20, nullable: true),
                    HUD = table.Column<string>(maxLength: 20, nullable: true),
                    HeadLightAdjustable = table.Column<string>(maxLength: 20, nullable: true),
                    Height = table.Column<string>(maxLength: 20, nullable: true),
                    HighBeam = table.Column<string>(maxLength: 20, nullable: true),
                    Horsepower = table.Column<string>(maxLength: 20, nullable: true),
                    IMMO = table.Column<string>(maxLength: 20, nullable: true),
                    ISOFIX = table.Column<string>(maxLength: 20, nullable: true),
                    InnerMirrorAutoDimming = table.Column<string>(maxLength: 20, nullable: true),
                    IntegralActiveSteering = table.Column<string>(maxLength: 20, nullable: true),
                    KneeAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    LWDS = table.Column<string>(maxLength: 20, nullable: true),
                    LeatherSW = table.Column<string>(maxLength: 20, nullable: true),
                    Length = table.Column<string>(maxLength: 20, nullable: true),
                    Level = table.Column<string>(maxLength: 20, nullable: true),
                    Localization = table.Column<string>(maxLength: 20, nullable: true),
                    LowBeam = table.Column<string>(maxLength: 20, nullable: true),
                    LumminumRim = table.Column<string>(maxLength: 20, nullable: true),
                    MASR = table.Column<string>(maxLength: 20, nullable: true),
                    MSRP = table.Column<string>(maxLength: 20, nullable: true),
                    MaxSpeed = table.Column<string>(maxLength: 20, nullable: true),
                    MirrorElecFold = table.Column<string>(maxLength: 20, nullable: true),
                    MirrorHeat = table.Column<string>(maxLength: 20, nullable: true),
                    MirrorMemory = table.Column<string>(maxLength: 20, nullable: true),
                    MultifunctionSW = table.Column<string>(maxLength: 20, nullable: true),
                    NVA = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    OfficialAcc = table.Column<string>(maxLength: 20, nullable: true),
                    OuterMirrorAutoDimming = table.Column<string>(maxLength: 20, nullable: true),
                    PEPS = table.Column<string>(maxLength: 20, nullable: true),
                    PKE = table.Column<string>(maxLength: 20, nullable: true),
                    PanoramicCamera = table.Column<string>(maxLength: 20, nullable: true),
                    PanoramicSunroof = table.Column<string>(maxLength: 20, nullable: true),
                    ParkAssistVision = table.Column<string>(maxLength: 20, nullable: true),
                    ParkBrake = table.Column<string>(nullable: true),
                    PassengerAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    PollenFilter = table.Column<string>(maxLength: 20, nullable: true),
                    Power = table.Column<string>(maxLength: 20, nullable: true),
                    PowerRevolvingSpeed = table.Column<string>(maxLength: 20, nullable: true),
                    PowerSource = table.Column<string>(maxLength: 20, nullable: true),
                    PowerSunroof = table.Column<string>(maxLength: 20, nullable: true),
                    PowerType = table.Column<string>(maxLength: 20, nullable: true),
                    RKE = table.Column<string>(maxLength: 20, nullable: true),
                    RearAir = table.Column<string>(maxLength: 20, nullable: true),
                    RearBrake = table.Column<string>(maxLength: 20, nullable: true),
                    RearCentralArmrest = table.Column<string>(maxLength: 20, nullable: true),
                    RearCupShelf = table.Column<string>(maxLength: 20, nullable: true),
                    RearDifferential = table.Column<string>(maxLength: 20, nullable: true),
                    RearElecWindow = table.Column<string>(nullable: true),
                    RearHeadAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    RearLCDScreen = table.Column<string>(maxLength: 20, nullable: true),
                    RearParkRadar = table.Column<string>(nullable: true),
                    RearPrivacyGlass = table.Column<string>(maxLength: 20, nullable: true),
                    RearSeatDownWay = table.Column<string>(maxLength: 20, nullable: true),
                    RearSeatElectAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    RearSeatHeat = table.Column<string>(maxLength: 20, nullable: true),
                    RearSeatMassage = table.Column<string>(maxLength: 20, nullable: true),
                    RearSeatVentilate = table.Column<string>(maxLength: 20, nullable: true),
                    RearSideAirBag = table.Column<string>(maxLength: 20, nullable: true),
                    RearSideSunshade = table.Column<string>(maxLength: 20, nullable: true),
                    RearSuspension = table.Column<string>(maxLength: 20, nullable: true),
                    RearTire = table.Column<string>(maxLength: 20, nullable: true),
                    RearTrack = table.Column<string>(maxLength: 20, nullable: true),
                    RearViewMirrorAdjustable = table.Column<string>(maxLength: 20, nullable: true),
                    RearWindowSunshade = table.Column<string>(maxLength: 20, nullable: true),
                    RearWiper = table.Column<string>(maxLength: 20, nullable: true),
                    Refrigerator = table.Column<string>(maxLength: 20, nullable: true),
                    RoofRack = table.Column<string>(maxLength: 20, nullable: true),
                    SRA = table.Column<string>(maxLength: 20, nullable: true),
                    SWHeat = table.Column<string>(maxLength: 20, nullable: true),
                    SWMemory = table.Column<string>(maxLength: 20, nullable: true),
                    SWShift = table.Column<string>(maxLength: 20, nullable: true),
                    SeatBeltPrompt = table.Column<string>(maxLength: 20, nullable: true),
                    SeatDriverElectAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SeatHeightAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SeatLumbarAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SeatMaterial = table.Column<string>(maxLength: 20, nullable: true),
                    SeatPassengerElectAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SeatShoulderAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SecondRowBackAngleAdjust = table.Column<string>(maxLength: 20, nullable: true),
                    SecondRowSeatMove = table.Column<string>(maxLength: 20, nullable: true),
                    SensingTrunk = table.Column<string>(maxLength: 20, nullable: true),
                    SensingWiper = table.Column<string>(maxLength: 20, nullable: true),
                    SideAssist = table.Column<string>(maxLength: 20, nullable: true),
                    SideSlidingDoor = table.Column<string>(maxLength: 20, nullable: true),
                    SpareTire = table.Column<string>(maxLength: 20, nullable: true),
                    SpeakerBrand = table.Column<string>(maxLength: 20, nullable: true),
                    SpeakerNo = table.Column<string>(maxLength: 20, nullable: true),
                    SportPackage = table.Column<string>(maxLength: 20, nullable: true),
                    SportSeat = table.Column<string>(maxLength: 20, nullable: true),
                    SteeringAssistLamp = table.Column<string>(maxLength: 20, nullable: true),
                    Stroke = table.Column<string>(maxLength: 20, nullable: true),
                    SunVisor = table.Column<string>(maxLength: 20, nullable: true),
                    TPMS = table.Column<string>(maxLength: 20, nullable: true),
                    TV = table.Column<string>(maxLength: 20, nullable: true),
                    TempControlRespective = table.Column<string>(maxLength: 20, nullable: true),
                    ThirdRowSeat = table.Column<string>(maxLength: 20, nullable: true),
                    Torque = table.Column<string>(maxLength: 20, nullable: true),
                    TorqueRevolvingSpeed = table.Column<string>(maxLength: 20, nullable: true),
                    TotalDoor = table.Column<string>(maxLength: 20, nullable: true),
                    TotalSeating = table.Column<string>(maxLength: 20, nullable: true),
                    VGRS = table.Column<string>(maxLength: 20, nullable: true),
                    ValveMechanism = table.Column<string>(maxLength: 20, nullable: true),
                    ValveNoPerCylinder = table.Column<string>(maxLength: 20, nullable: true),
                    Wheelbase = table.Column<string>(maxLength: 20, nullable: true),
                    Width = table.Column<string>(maxLength: 20, nullable: true),
                    YearId = table.Column<int>(nullable: false),
                    ZeroTirePressure = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarTypes_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CarTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InnerColors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CarTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Value = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnerColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InnerColors_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarTypes_YearId",
                table: "CarTypes",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_CarTypeId",
                table: "Colors",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Factories_BrandId",
                table: "Factories",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_InnerColors_CarTypeId",
                table: "InnerColors",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Series_FactoryId",
                table: "Series",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Years_SerieId",
                table: "Years",
                column: "SerieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "InnerColors");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
