﻿// <auto-generated />
using Asset_Tracking_Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asset_Tracking_Database.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240527123906_SeedingDataComputerMobileTable")]
    partial class SeedingDataComputerMobileTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asset_Tracking_Database.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MdelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Computers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "HP",
                            Currency = "EUR",
                            MdelName = "Elitebook",
                            Office = "Spain",
                            Price = 1423m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Asus",
                            Currency = "USD",
                            MdelName = "W234",
                            Office = "USA",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "HP",
                            Currency = "SEK",
                            MdelName = "Elitebook",
                            Office = "Sweden",
                            Price = 588m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Lenovo",
                            Currency = "USD",
                            MdelName = "Yoga730",
                            Office = "USA",
                            Price = 835m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Lenovo",
                            Currency = "USD",
                            MdelName = "Yoga432",
                            Office = "USA",
                            Price = 745m
                        });
                });

            modelBuilder.Entity("Asset_Tracking_Database.Mobile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MdelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Mobiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "iphone",
                            Currency = "EUR",
                            MdelName = "8",
                            Office = "Spain",
                            Price = 970m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "iphone",
                            Currency = "EUR",
                            MdelName = "11",
                            Office = "Spain",
                            Price = 990m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "iphone",
                            Currency = "SEK",
                            MdelName = "x",
                            Office = "Sweden",
                            Price = 970m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Motorola",
                            Currency = "SEK",
                            MdelName = "Razer",
                            Office = "Sweden",
                            Price = 970m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Motorola",
                            Currency = "SEK",
                            MdelName = "G",
                            Office = "Sweden",
                            Price = 870m
                        });
                });

            modelBuilder.Entity("ComputerMobile", b =>
                {
                    b.Property<int>("ComputerListId")
                        .HasColumnType("int");

                    b.Property<int>("MobileListId")
                        .HasColumnType("int");

                    b.HasKey("ComputerListId", "MobileListId");

                    b.HasIndex("MobileListId");

                    b.ToTable("ComputerMobile");

                    b.HasData(
                        new
                        {
                            ComputerListId = 1,
                            MobileListId = 1
                        });
                });

            modelBuilder.Entity("ComputerMobile", b =>
                {
                    b.HasOne("Asset_Tracking_Database.Computer", null)
                        .WithMany()
                        .HasForeignKey("ComputerListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asset_Tracking_Database.Mobile", null)
                        .WithMany()
                        .HasForeignKey("MobileListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
