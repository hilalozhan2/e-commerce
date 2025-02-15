﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using guitars.Data;

#nullable disable

namespace guitars.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231205110718_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("guitars.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("guitars.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<string>("PictureURl")
                        .HasColumnType("longtext");

                    b.Property<string>("Price")
                        .HasColumnType("longtext");

                    b.Property<string>("Shape")
                        .HasColumnType("longtext");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("guitars.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("guitars.Models.Product", b =>
                {
                    b.HasOne("guitars.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("guitars.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
