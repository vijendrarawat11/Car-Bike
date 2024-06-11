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
    [Migration("20240610063239_addcolumn")]
    partial class addcolumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cars_Bikes.Models.TwoWheeler", b =>
                {
                    b.Property<string>("TwoWheelerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BasePrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TwoWBrandId")
                        .HasColumnType("int");

                    b.Property<int>("TwoWheelerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TwoWheelerId"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TwoWheelerName");

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
