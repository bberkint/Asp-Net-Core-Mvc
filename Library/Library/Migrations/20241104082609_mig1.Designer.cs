﻿// <auto-generated />
using System;
using Library.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241104082609_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("BookTypeID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Models.BookType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("Library.Models.Operation", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "BookID");

                    b.HasIndex("BookID");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("Library.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedData")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.HasOne("Library.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.BookType", "BookType")
                        .WithMany("Books")
                        .HasForeignKey("BookTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("BookType");
                });

            modelBuilder.Entity("Library.Models.Operation", b =>
                {
                    b.HasOne("Library.Models.Book", "Book")
                        .WithMany("Operations")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Student", "Student")
                        .WithMany("Operations")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Library.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.Book", b =>
                {
                    b.Navigation("Operations");
                });

            modelBuilder.Entity("Library.Models.BookType", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Models.Student", b =>
                {
                    b.Navigation("Operations");
                });
#pragma warning restore 612, 618
        }
    }
}
