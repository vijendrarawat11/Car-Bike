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
    [Migration("20240620084600_AddFeaturesSafetyTables")]
    partial class AddFeaturesSafetyTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Cars_Bikes.Models.TWFeatures", b =>
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
