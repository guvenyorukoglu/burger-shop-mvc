﻿// <auto-generated />
using System;
using BurgerShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerShop.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231127084927_mig_4")]
    partial class mig_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

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
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Extra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExtraImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtraName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ExtraPrice")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MenuImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<decimal>("MenuPrice")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("MenuSize")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("MenuName", "MenuSize");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("OrderQuantity")
                        .HasColumnType("smallint");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("ShippedAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.OrdersExtras", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExtraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ExtraPrice")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<short>("ExtraQuantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("ExtraTotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ExtraId");

                    b.HasIndex("ExtraId");

                    b.ToTable("OrdersExtras");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.OrdersMenus", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("MenuPrice")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<short>("MenuQuantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("MenuTotalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("OrdersMenus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "9e31b318-a285-413f-8981-9aee6588eabd",
                            ConcurrencyStamp = "19cb602b-80c1-48f3-a909-0663fe4b3e21",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "6783f946-d434-437b-bb1c-485a61eafe7c",
                            ConcurrencyStamp = "fec9644e-dbeb-4e0a-89f5-f75ae59a49fa",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Address", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("Addresses")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Order", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.OrdersExtras", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.Extra", "Extra")
                        .WithMany("OrdersExtras")
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerShop.Domain.Entities.Concrete.Order", "Order")
                        .WithMany("OrdersExtras")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Extra");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.OrdersMenus", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.Menu", "Menu")
                        .WithMany("OrdersMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerShop.Domain.Entities.Concrete.Order", "Order")
                        .WithMany("OrdersMenus")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");
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
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", null)
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

                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BurgerShop.Domain.Entities.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.AppUser", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Extra", b =>
                {
                    b.Navigation("OrdersExtras");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Menu", b =>
                {
                    b.Navigation("OrdersMenus");
                });

            modelBuilder.Entity("BurgerShop.Domain.Entities.Concrete.Order", b =>
                {
                    b.Navigation("OrdersExtras");

                    b.Navigation("OrdersMenus");
                });
#pragma warning restore 612, 618
        }
    }
}