﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobnet.Store.Infrastructure.Persistence;

#nullable disable

namespace Mobnet.Store.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210919185032_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-rc.1.21452.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Value")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxDiscount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxDiscount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PurchasePrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stock")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("StockMin")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce04b782-d408-4ff4-b6ec-d195532fb1e1"),
                            Code = 1L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Biquine",
                            Price = 99.90m,
                            PurchasePrice = 38.90m,
                            Stock = 4m,
                            StockMin = 2m
                        },
                        new
                        {
                            Id = new Guid("d882f561-e615-450c-adb8-4fd2e55cfc71"),
                            Code = 2L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Preto",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Boné Nike",
                            Price = 12m,
                            PurchasePrice = 24.90m,
                            Stock = 5m,
                            StockMin = 3m
                        },
                        new
                        {
                            Id = new Guid("845a2abb-8eae-49b4-b9c1-daf199c4af30"),
                            Code = 3L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Snorkel",
                            Price = 14m,
                            PurchasePrice = 29.90m,
                            Stock = 8m,
                            StockMin = 4m
                        },
                        new
                        {
                            Id = new Guid("c19fffc4-0820-4a69-8d3c-4a0d7c1222bf"),
                            Code = 4L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Chapeu",
                            Price = 27.90m,
                            PurchasePrice = 12m,
                            Stock = 4m,
                            StockMin = 2m
                        },
                        new
                        {
                            Id = new Guid("c2e5d554-691b-44e4-b20b-392f0398e85f"),
                            Code = 5L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Saída de Praia",
                            Price = 78.90m,
                            PurchasePrice = 33m,
                            Stock = 4m,
                            StockMin = 2m
                        },
                        new
                        {
                            Id = new Guid("1c85699c-e881-4375-9dc6-dc0f30b56a7d"),
                            Code = 6L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Canga",
                            Price = 99.90m,
                            PurchasePrice = 40m,
                            Stock = 4m,
                            StockMin = 2m
                        },
                        new
                        {
                            Id = new Guid("fb623a4d-5e59-4e59-9633-eef4fb6d80a4"),
                            Code = 7L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Óculos'",
                            Price = 19.90m,
                            PurchasePrice = 8m,
                            Stock = 10m,
                            StockMin = 5m
                        },
                        new
                        {
                            Id = new Guid("7113137d-317e-4679-8530-f67b4a59d0f9"),
                            Code = 8L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Pequena",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Namoradeira",
                            Price = 24.90m,
                            PurchasePrice = 12m,
                            Stock = 4m,
                            StockMin = 2m
                        },
                        new
                        {
                            Id = new Guid("cc714244-79b4-46ab-b93b-fe6b2897ee1c"),
                            Code = 9L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "M",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "Sunga",
                            Price = 29.90m,
                            PurchasePrice = 17m,
                            Stock = 10m,
                            StockMin = 4m
                        },
                        new
                        {
                            Id = new Guid("89a8f1e7-c5ac-4310-a0d7-1cf322ef2a33"),
                            Code = 10L,
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "M",
                            LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MaxDiscount = 10m,
                            Name = "UV",
                            Price = 59.90m,
                            PurchasePrice = 23m,
                            Stock = 18m,
                            StockMin = 10m
                        });
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("Mobnet.Store.Domain.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mobnet.Store.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}