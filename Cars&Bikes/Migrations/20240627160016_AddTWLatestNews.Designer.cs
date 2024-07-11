﻿// <auto-generated />
using Cars_Bikes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cars_Bikes.Migrations
{
    [DbContext(typeof(BrandDB))]
    [Migration("20240627160016_AddTWLatestNews")]
    partial class AddTWLatestNews
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cars_Bikes.Models.TWCharging", b =>
                {
                    b.Property<int>("TWChargingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWChargingId"));

                    b.Property<string>("ChargingAtChargingStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChargingAtHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWChargingId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWChargings");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWChassisAndSuspension", b =>
                {
                    b.Property<int>("TWChassisAndSuspensionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWChassisAndSuspensionId"));

                    b.Property<string>("BodyGraphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWChassisAndSuspensionId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWChassisAndSuspensions");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWDimensionsAndCapacity", b =>
                {
                    b.Property<int>("TWDimensionsAndCapacityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWDimensionsAndCapacityId"));

                    b.Property<string>("FuelCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelReserve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroundClearance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KerbWeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaddleHeight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wheelbase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWDimensionsAndCapacityId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWDimensionsAndCapacities");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWElectricals", b =>
                {
                    b.Property<int>("TWElectricalsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWElectricalsId"));

                    b.Property<string>("DRLs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistanceToEmptyIndicator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headlight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LEDTailLights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LowFuelIndicato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PilotLamps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TailLight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TurnSignalLamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWElectricalsId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWElectricals");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWEngineAndTransmission", b =>
                {
                    b.Property<int>("TWEngineAndTransmissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWEngineAndTransmissionId"));

                    b.Property<string>("Clutch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompressionRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoolingSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Displacement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmissionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelSupply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ignition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxTorque")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumOfCylinders")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Starting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("ValvePerCylinder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWEngineAndTransmissionId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWEngineAndTransmissions");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWFeatures", b =>
                {
                    b.Property<int>("TWFeaturesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWFeaturesId"));

                    b.Property<string>("ABS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyGraphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelGauge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstrumentConsole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LEDTailLight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Odometer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerFootrest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speedometer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tachometer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tripmeter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWFeaturesId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWFeatures");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWLatestNews", b =>
                {
                    b.Property<int>("TWLatestNewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWLatestNewsId"));

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsDetail")
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("NewsHeading")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NewsSummary")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("TWLatestNewsId");

                    b.ToTable("TWLatestNews");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWMileageAndPerformance", b =>
                {
                    b.Property<int>("TWMileageAndPerformanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWMileageAndPerformanceId"));

                    b.Property<string>("CityMileage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighwayMileage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverallMileage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWMileageAndPerformanceId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWMileageAndPerformances");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWMotorAndBattery", b =>
                {
                    b.Property<int>("TWMotorAndBatteryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWMotorAndBatteryId"));

                    b.Property<string>("BatteryCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriveType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeakPower")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWMotorAndBatteryId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWMotorAndBatteries");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWSafety", b =>
                {
                    b.Property<int>("TWSafetyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWSafetyId"));

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineKillSwitch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassSwitch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWSafetyId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWSafety");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWSpec", b =>
                {
                    b.Property<int>("TWSpecId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWSpecId"));

                    b.Property<string>("Displacement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuelCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Milage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RearBrake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWSpecId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWSpec");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWTyresAndBrakes", b =>
                {
                    b.Property<int>("TWTyresAndBrakesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWTyresAndBrakesId"));

                    b.Property<string>("FrontBrakeDiameter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontSuspension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadialTyre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RearBrakeDiameter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RearSuspension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWTyresAndBrakesId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWTyresAndBrakes");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWUnderpinning", b =>
                {
                    b.Property<int>("TWUnderpinningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWUnderpinningId"));

                    b.Property<string>("ABS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrakesFront")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrakesRear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuspensionFront")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuspensionRear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TubelessTyre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWheelerId")
                        .HasColumnType("int");

                    b.Property<string>("TyreSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Varients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WheelSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WheelType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWUnderpinningId");

                    b.HasIndex("TwoWheelerId");

                    b.ToTable("TWUnderpinnings");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TwoWheeler", b =>
                {
                    b.Property<int>("TwoWheelerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TwoWheelerId"));

                    b.Property<string>("BasePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TWImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWBrandId")
                        .HasColumnType("int");

                    b.Property<string>("TwoWheelerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TwoWheelerId");

                    b.HasIndex("TwoWBrandId");

                    b.ToTable("Twowheelers");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TwoWheelerBrand", b =>
                {
                    b.Property<int>("TWBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TWBrandId"));

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TWBrandId");

                    b.ToTable("TwowheelerBrands");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWCharging", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWChassisAndSuspension", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWDimensionsAndCapacity", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWElectricals", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWEngineAndTransmission", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWFeatures", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWMileageAndPerformance", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWMotorAndBattery", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWSafety", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWSpec", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWTyresAndBrakes", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TWUnderpinning", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheeler", "TwoWheeler")
                        .WithMany()
                        .HasForeignKey("TwoWheelerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TwoWheeler");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TwoWheeler", b =>
                {
                    b.HasOne("Cars_Bikes.Models.TwoWheelerBrand", "TwoWheelerBrands")
                        .WithMany("TwoWheelers")
                        .HasForeignKey("TwoWBrandId")
                        .IsRequired();

                    b.Navigation("TwoWheelerBrands");
                });

            modelBuilder.Entity("Cars_Bikes.Models.TwoWheelerBrand", b =>
                {
                    b.Navigation("TwoWheelers");
                });
#pragma warning restore 612, 618
        }
    }
}
