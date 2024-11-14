﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Udemy.EfCore.Data.Context;

namespace Udemy.EfCore.Data.Migrations
{
    [DbContext(typeof(UdemyContext))]
    [Migration("20241108215104_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("category_name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number", "Name");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("product_name");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 3)
                        .HasColumnType("decimal(18,3)")
                        .HasColumnName("product_price");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.SaleHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("SaleHistorys");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.FullTimeEmployee", b =>
                {
                    b.HasBaseType("Udemy.EfCore.Data.Entities.Employee");

                    b.Property<decimal>("HourlWage")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("FullTimeEmployees");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.PartTimeEmployee", b =>
                {
                    b.HasBaseType("Udemy.EfCore.Data.Entities.Employee");

                    b.Property<decimal>("DailyWage")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("PartTimeEmployees");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.ProductCategory", b =>
                {
                    b.HasOne("Udemy.EfCore.Data.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Udemy.EfCore.Data.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.ProductDetail", b =>
                {
                    b.HasOne("Udemy.EfCore.Data.Entities.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("Udemy.EfCore.Data.Entities.ProductDetail", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.SaleHistory", b =>
                {
                    b.HasOne("Udemy.EfCore.Data.Entities.Product", "Product")
                        .WithMany("SaleHistories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.FullTimeEmployee", b =>
                {
                    b.HasOne("Udemy.EfCore.Data.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("Udemy.EfCore.Data.Entities.FullTimeEmployee", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.PartTimeEmployee", b =>
                {
                    b.HasOne("Udemy.EfCore.Data.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("Udemy.EfCore.Data.Entities.PartTimeEmployee", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("Udemy.EfCore.Data.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductDetail");

                    b.Navigation("SaleHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
