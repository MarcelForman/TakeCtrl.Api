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
    [Migration("20230607120718_AddUser")]
    partial class AddUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<double?>("IopsRead")
                        .HasColumnType("float");

                    b.Property<double?>("IopsWrite")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("mbitIn")
                        .HasColumnType("float");

                    b.Property<double?>("mbitOut")
                        .HasColumnType("float");

                    b.Property<double?>("percent")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Usages");
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
