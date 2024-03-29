﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TakeCtrl.Api.Data;

#nullable disable

namespace TakeCtrl.Api.Migrations
{
    [DbContext(typeof(TakeCtrlDbContext))]
    [Migration("20230609134953_AddedUsageDataDiskNetwork")]
    partial class AddedUsageDataDiskNetwork
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TakeCtrl.Api.Entities.Firewall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndPort")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Protocol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StartPort")
                        .HasColumnType("int");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Firewalls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "RDP",
                            EndPort = 3389,
                            IsEnabled = true,
                            Protocol = "tcp",
                            StartPort = 3389,
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 2,
                            Description = "FTP",
                            EndPort = 21,
                            IsEnabled = false,
                            Protocol = "tcp",
                            StartPort = 21,
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 3,
                            Description = "SSL",
                            EndPort = 22,
                            IsEnabled = true,
                            Protocol = "tcp",
                            StartPort = 22,
                            UUID = "878859d6-f616-11ed-b67e-0242ac120002"
                        });
                });

            modelBuilder.Entity("TakeCtrl.Api.Entities.Server", b =>
                {
                    b.Property<string>("UUID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CPUAmount")
                        .HasColumnType("int");

                    b.Property<int>("DiskSize")
                        .HasColumnType("int");

                    b.Property<string>("IPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemorySize")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UUID");

                    b.ToTable("Servers");

                    b.HasData(
                        new
                        {
                            UUID = "878859d6-f616-11ed-b67e-0242ac120002",
                            CPUAmount = 6,
                            DiskSize = 136464745,
                            IPAddress = "56.84.125.212",
                            MemorySize = 3456789,
                            Name = "VPS-1",
                            Status = "running"
                        },
                        new
                        {
                            UUID = "081b833e-f617-11ed-b67e-0242ac120002",
                            CPUAmount = 6,
                            DiskSize = 136464745,
                            IPAddress = "56.84.125.213",
                            MemorySize = 3456789,
                            Name = "VPS-2",
                            Status = "running"
                        },
                        new
                        {
                            UUID = "111d37ca-f617-11ed-b67e-0242ac120002",
                            CPUAmount = 6,
                            DiskSize = 136464745,
                            IPAddress = "56.84.125.214",
                            MemorySize = 3456789,
                            Name = "VPS-3",
                            Status = "running"
                        },
                        new
                        {
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002",
                            CPUAmount = 6,
                            DiskSize = 136464745,
                            IPAddress = "56.84.125.215",
                            MemorySize = 3456789,
                            Name = "VPS-4",
                            Status = "running"
                        });
                });

            modelBuilder.Entity("TakeCtrl.Api.Entities.Usage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("IopsRead")
                        .HasColumnType("float");

                    b.Property<double?>("IopsWrite")
                        .HasColumnType("float");

                    b.Property<double?>("MbitIn")
                        .HasColumnType("float");

                    b.Property<double?>("MbitOut")
                        .HasColumnType("float");

                    b.Property<double?>("Percent")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 6, 1, 10, 10, 0, 0, DateTimeKind.Unspecified),
                            Percent = 20.0,
                            Type = "CPU",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 6, 1, 10, 15, 0, 0, DateTimeKind.Unspecified),
                            Percent = 40.0,
                            Type = "CPU",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            Percent = 80.0,
                            Type = "CPU",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            MbitIn = 456789.0,
                            Type = "Network",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            MbitIn = 456123.0,
                            Type = "Network",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            MbitOut = 56894.0,
                            Type = "Network",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            MbitOut = 56241.0,
                            Type = "Network",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            IopsRead = 653.0,
                            Type = "Disk",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            IopsRead = 645.0,
                            Type = "Disk",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            IopsWrite = 423.0,
                            Type = "Disk",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2023, 6, 1, 10, 20, 0, 0, DateTimeKind.Unspecified),
                            IopsWrite = 380.0,
                            Type = "Disk",
                            UUID = "eb6c28c2-f618-11ed-b67e-0242ac120002"
                        });
                });

            modelBuilder.Entity("TakeCtrl.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAdmin = true,
                            Name = "user",
                            Password = "welkom",
                            userName = "user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
