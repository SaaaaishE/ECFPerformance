﻿// <auto-generated />
using System;
using ECFPerformance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    [DbContext(typeof(EcfDbContext))]
    [Migration("20230816093312_shoppingCartTurbo")]
    partial class shoppingCartTurbo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConnectingRodProjectCar", b =>
                {
                    b.Property<int>("ConnectingRodsId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectCarsId")
                        .HasColumnType("int");

                    b.HasKey("ConnectingRodsId", "ProjectCarsId");

                    b.HasIndex("ProjectCarsId");

                    b.ToTable("ConnectingRodProjectCar");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7463b1a4-635d-462c-879e-e2f4eaa74824"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ef63267-541f-4ea2-8885-0df0844a4425",
                            Email = "ecfperformance@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Alex",
                            LastName = "Gavrilov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ecfperformance@gmail.com",
                            NormalizedUserName = "ecfperformance@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEBQC4lYvk4le98qQml22/r6b5e3zE4b3Ig1XfTz+lS0PUdCkBIm0GPYJ77Av+fXOwg==",
                            PhoneNumber = "+3594567891",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0f42cdc1-3334-41ca-b9b0-98edf2ec0bbc",
                            TwoFactorEnabled = false,
                            UserName = "ecfperformance@gmail.com"
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Engine"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Chassis"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Suspension"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Exhaust"
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BeamTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PistonBoltDiameter")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BeamTypeId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ConnectingRods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BeamTypeId = 1,
                            CategoryId = 1,
                            Length = 135,
                            MainImage = "https://www.eaglerod.com/images/1c475ca0-bfd5-11ea-b02a-c48ef5f8d3b6/jpg/5313-4340-h-beam-bmw-38-arp-2000-bolts/crs-5313b63d-1.jpg",
                            Make = "Eagle",
                            Name = "BMW Beam Type I Connecting Rod 135mm",
                            PistonBoltDiameter = 22,
                            Price = 670m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 2,
                            BeamTypeId = 2,
                            CategoryId = 1,
                            Length = 135,
                            MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-6/default/main/forged-rods-cr-6(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp",
                            Make = "MaxPeedingRods",
                            Name = "BMW Beam Type H Connecting Rod 135mm",
                            PistonBoltDiameter = 22,
                            Price = 580m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 3,
                            BeamTypeId = 2,
                            CategoryId = 1,
                            Length = 133,
                            MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000",
                            Make = "MaxPeedingRods",
                            Name = "Mazda H Beam ",
                            PistonBoltDiameter = 20,
                            Price = 357m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            BeamTypeId = 1,
                            CategoryId = 1,
                            Length = 133,
                            MainImage = "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/84c3ce8a-bfd5-11ea-87b6-e6954ea1f6b1.jpg",
                            Make = "Eagle",
                            Name = "Mazda I Beam",
                            PistonBoltDiameter = 20,
                            Price = 460m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 5,
                            BeamTypeId = 2,
                            CategoryId = 1,
                            Length = 137,
                            MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp",
                            Make = "MaxPeedingRods",
                            Name = "Honda H Beam",
                            PistonBoltDiameter = 19,
                            Price = 359m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 6,
                            BeamTypeId = 1,
                            CategoryId = 1,
                            Length = 137,
                            MainImage = "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/870fa77e-bfd3-11ea-b02b-15c463fe2bce.jpg",
                            Make = "Eagle",
                            Name = "Honda I Beam",
                            PistonBoltDiameter = 19,
                            Price = 465m,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRodBeamType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ConnectingRodBeam")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConnectingRodBeamType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConnectingRodBeam = 0
                        },
                        new
                        {
                            Id = 2,
                            ConnectingRodBeam = 1
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRodEngineType", b =>
                {
                    b.Property<int>("CompatibleEngineId")
                        .HasColumnType("int");

                    b.Property<int>("CompatibleRodId")
                        .HasColumnType("int");

                    b.HasKey("CompatibleEngineId", "CompatibleRodId");

                    b.HasIndex("CompatibleRodId");

                    b.ToTable("ConnectingRodEngineType");

                    b.HasData(
                        new
                        {
                            CompatibleEngineId = 1,
                            CompatibleRodId = 1
                        },
                        new
                        {
                            CompatibleEngineId = 1,
                            CompatibleRodId = 2
                        },
                        new
                        {
                            CompatibleEngineId = 2,
                            CompatibleRodId = 1
                        },
                        new
                        {
                            CompatibleEngineId = 2,
                            CompatibleRodId = 2
                        },
                        new
                        {
                            CompatibleEngineId = 5,
                            CompatibleRodId = 3
                        },
                        new
                        {
                            CompatibleEngineId = 5,
                            CompatibleRodId = 4
                        },
                        new
                        {
                            CompatibleEngineId = 6,
                            CompatibleRodId = 3
                        },
                        new
                        {
                            CompatibleEngineId = 6,
                            CompatibleRodId = 4
                        },
                        new
                        {
                            CompatibleEngineId = 3,
                            CompatibleRodId = 5
                        },
                        new
                        {
                            CompatibleEngineId = 3,
                            CompatibleRodId = 6
                        },
                        new
                        {
                            CompatibleEngineId = 4,
                            CompatibleRodId = 5
                        },
                        new
                        {
                            CompatibleEngineId = 4,
                            CompatibleRodId = 6
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.EngineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EngineCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EngineType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EngineCode = 0
                        },
                        new
                        {
                            Id = 2,
                            EngineCode = 1
                        },
                        new
                        {
                            Id = 3,
                            EngineCode = 4
                        },
                        new
                        {
                            Id = 4,
                            EngineCode = 5
                        },
                        new
                        {
                            Id = 5,
                            EngineCode = 2
                        },
                        new
                        {
                            Id = 6,
                            EngineCode = 3
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.Turbo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ScrollTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ScrollTypeId");

                    b.ToTable("Turbos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            MainImage = "https://m.media-amazon.com/images/I/612l0wYluUL._AC_SX522_.jpg",
                            Make = "MaxPeedingRods",
                            Name = "GT30",
                            Price = 130.00m,
                            Quantity = 3,
                            ScrollTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            MainImage = "https://s19529.pcdn.co/wp-content/uploads/2021/02/Screen-Shot-2021-02-22-at-10.05.38-AM.png",
                            Make = "MaxPeedingRods",
                            Name = "GT35",
                            Price = 230.00m,
                            Quantity = 3,
                            ScrollTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            MainImage = "https://th.bing.com/th/id/OIP.z3vjnJxtodUyIYBQigac8gHaGw?pid=ImgDet&rs=1",
                            Make = "Holset",
                            Name = "HX40",
                            Price = 500.00m,
                            Quantity = 3,
                            ScrollTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            MainImage = "https://th.bing.com/th/id/R.145fdefb10871f3b499c8e9bbc1ff9c8?rik=w4kn89cj4XnJlw&pid=ImgRaw&r=0",
                            Make = "Holset",
                            Name = "HX35",
                            Price = 450.00m,
                            Quantity = 3,
                            ScrollTypeId = 2
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.TurboScrollType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ScrollType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ScrollTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ScrollType = 1
                        },
                        new
                        {
                            Id = 2,
                            ScrollType = 0
                        });
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.TurboShoppingCart", b =>
                {
                    b.Property<Guid>("ShoppingCartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TurboId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartId", "TurboId");

                    b.HasIndex("TurboId");

                    b.ToTable("TurboShoppingCart");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Projects.ProjectCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectCars");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.ShoppingCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProjectCarTurbo", b =>
                {
                    b.Property<int>("ProjectCarsId")
                        .HasColumnType("int");

                    b.Property<int>("TurbosId")
                        .HasColumnType("int");

                    b.HasKey("ProjectCarsId", "TurbosId");

                    b.HasIndex("TurbosId");

                    b.ToTable("ProjectCarTurbo");
                });

            modelBuilder.Entity("ShoppingCartTurbo", b =>
                {
                    b.Property<Guid>("ShoppingCartsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TurbosInCartId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartsId", "TurbosInCartId");

                    b.HasIndex("TurbosInCartId");

                    b.ToTable("ShoppingCartTurbo");
                });

            modelBuilder.Entity("ConnectingRodProjectCar", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRod", null)
                        .WithMany()
                        .HasForeignKey("ConnectingRodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Projects.ProjectCar", null)
                        .WithMany()
                        .HasForeignKey("ProjectCarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRod", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRodBeamType", "BeamType")
                        .WithMany("ConnectingRods")
                        .HasForeignKey("BeamTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("ConnectingRods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BeamType");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRodEngineType", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.EngineType", "CompatibleEngine")
                        .WithMany("ConnectingRods")
                        .HasForeignKey("CompatibleEngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRod", "CompatibleRod")
                        .WithMany("CompatibleEngines")
                        .HasForeignKey("CompatibleRodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompatibleEngine");

                    b.Navigation("CompatibleRod");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.Turbo", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Turbos")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.TurboScrollType", "ScrollType")
                        .WithMany("Turbos")
                        .HasForeignKey("ScrollTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ScrollType");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.TurboShoppingCart", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.Turbo", "Turbo")
                        .WithMany()
                        .HasForeignKey("TurboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoppingCart");

                    b.Navigation("Turbo");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.ShoppingCart", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectCarTurbo", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Projects.ProjectCar", null)
                        .WithMany()
                        .HasForeignKey("ProjectCarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.Turbo", null)
                        .WithMany()
                        .HasForeignKey("TurbosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShoppingCartTurbo", b =>
                {
                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.ShoppingCart", null)
                        .WithMany()
                        .HasForeignKey("ShoppingCartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECFPerformance.Infrastructure.Data.Models.Engine.Turbo", null)
                        .WithMany()
                        .HasForeignKey("TurbosInCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("ConnectingRods");

                    b.Navigation("Turbos");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRod", b =>
                {
                    b.Navigation("CompatibleEngines");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.ConnectingRodBeamType", b =>
                {
                    b.Navigation("ConnectingRods");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.EngineType", b =>
                {
                    b.Navigation("ConnectingRods");
                });

            modelBuilder.Entity("ECFPerformance.Infrastructure.Data.Models.Engine.TurboScrollType", b =>
                {
                    b.Navigation("Turbos");
                });
#pragma warning restore 612, 618
        }
    }
}
