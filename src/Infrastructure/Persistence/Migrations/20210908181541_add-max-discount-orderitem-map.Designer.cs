﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mobnet.Store.Infrastructure.Persistence;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Mobnet.Store.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210908181541_add-max-discount-orderitem-map")]
    partial class addmaxdiscountorderitemmap
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.7.21378.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("MaxDiscount")
                        .HasColumnType("numeric");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Mobnet.Store.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("MaxDiscount")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("PurchasePrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("Stock")
                        .HasColumnType("numeric");

                    b.Property<decimal>("StockMin")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6e628d63-a31a-4913-a183-973ac759304e"),
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
                            Id = new Guid("e896ce52-1ae7-43b1-9eb1-60ae3c24f7bc"),
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
                            Id = new Guid("368e3be3-4bec-41ad-8226-9662ba9dbfc8"),
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
                            Id = new Guid("5bcff8ed-175e-44e8-84c4-75ffac0b8129"),
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
                            Id = new Guid("7d96807c-4780-44f6-adad-1528c697c4d5"),
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
                            Id = new Guid("018fa1a8-b622-4a3f-9b2c-324d2a64a5e5"),
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
                            Id = new Guid("c0f88b25-b646-4fae-ae48-574bff8f33cc"),
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
                            Id = new Guid("be1ba3c8-4cfa-4763-9e48-48febfd402cc"),
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
                            Id = new Guid("8cb8724f-baa7-4ad5-8fee-ab9f121f8287"),
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
                            Id = new Guid("2ee7852d-ecd5-4193-9b58-bd288e6ae15a"),
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
