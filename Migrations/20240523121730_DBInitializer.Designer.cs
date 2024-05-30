﻿// <auto-generated />
using System;
using Clothes_Online_Shop.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clothes_Online_Shop.DB.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20240523121730_DBInitializer")]
    partial class DBInitializer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.FavoriteProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("FavoriteProducts");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.ImgInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ImgInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "/img/hudi-white-1.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 2,
                            Path = "/img/hudi-white-2.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 3,
                            Path = "/img/hudi-white-3.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 4,
                            Path = "/img/hudi-white-4.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 5,
                            Path = "/img/hudi-white-5.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 6,
                            Path = "/img/hudi-white-6.jpg",
                            ProductId = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3")
                        },
                        new
                        {
                            Id = 7,
                            Path = "/img/hudi-black-1.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 8,
                            Path = "/img/hudi-black-2.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 9,
                            Path = "/img/hudi-black-3.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 10,
                            Path = "/img/hudi-black-4.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 11,
                            Path = "/img/hudi-black-5.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 12,
                            Path = "/img/hudi-black-6.jpg",
                            ProductId = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e")
                        },
                        new
                        {
                            Id = 13,
                            Path = "/img/vest-1.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 14,
                            Path = "/img/vest-2.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 15,
                            Path = "/img/vest-3.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 16,
                            Path = "/img/vest-4.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 17,
                            Path = "/img/vest-5.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 18,
                            Path = "/img/vest-6.jpg",
                            ProductId = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e")
                        },
                        new
                        {
                            Id = 19,
                            Path = "/img/woman-costume-1.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        },
                        new
                        {
                            Id = 20,
                            Path = "/img/woman-costume-2.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        },
                        new
                        {
                            Id = 21,
                            Path = "/img/woman-costume-3.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        },
                        new
                        {
                            Id = 22,
                            Path = "/img/woman-costume-4.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        },
                        new
                        {
                            Id = 23,
                            Path = "/img/woman-costume-5.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        },
                        new
                        {
                            Id = 24,
                            Path = "/img/woman-costume-6.jpg",
                            ProductId = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a")
                        });
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Care")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabric")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Like")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"),
                            Brand = "Stone Island",
                            Care = "Деликатная машинная стирка",
                            Color = "Белый",
                            Cost = 1199m,
                            Country = "USA",
                            Description = "Высокое качество по доступной цене",
                            Fabric = "80% хлопок 20% полиэстер",
                            Item = "st0171",
                            Like = false,
                            Name = "Зип худи шерпа с капюшоном",
                            Size = 50
                        },
                        new
                        {
                            Id = new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"),
                            Brand = "Stone Island",
                            Care = "Деликатная машинная стирка",
                            Color = "Черный",
                            Cost = 1499m,
                            Country = "USA",
                            Description = "Высокое качество по доступной цене",
                            Fabric = "80% хлопок 20% полиэстер",
                            Item = "st0170",
                            Like = false,
                            Name = "Зип худи шерпа с капюшоном",
                            Size = 52
                        },
                        new
                        {
                            Id = new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"),
                            Brand = "Stone Island",
                            Care = "Ручная стирка",
                            Color = "Бежевый",
                            Cost = 999m,
                            Country = "USA",
                            Description = "Лучшее сохранение тепла",
                            Fabric = "90% пух 10% полиэстер",
                            Item = "sk0500",
                            Like = false,
                            Name = "Пуховая жилетка",
                            Size = 49
                        },
                        new
                        {
                            Id = new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"),
                            Brand = "Stone Island",
                            Care = "Ручная деликатная стирка при температуре на более 30",
                            Color = "Салатовый",
                            Cost = 2999m,
                            Country = "USA",
                            Description = "Повседневный стиль",
                            Fabric = "100% хлопок",
                            Item = "wr0343",
                            Like = false,
                            Name = "Женский костюм",
                            Size = 33
                        });
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.UserDeliveryInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserDeliveryInfo");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.CartItem", b =>
                {
                    b.HasOne("Clothes_Online_Shop.DB.Models.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("Clothes_Online_Shop.DB.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("Clothes_Online_Shop.DB.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Cart");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.FavoriteProduct", b =>
                {
                    b.HasOne("Clothes_Online_Shop.DB.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.ImgInfo", b =>
                {
                    b.HasOne("Clothes_Online_Shop.DB.Models.Product", "Product")
                        .WithMany("ImgList")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Order", b =>
                {
                    b.HasOne("Clothes_Online_Shop.DB.Models.UserDeliveryInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Clothes_Online_Shop.DB.Models.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("ImgList");
                });
#pragma warning restore 612, 618
        }
    }
}
