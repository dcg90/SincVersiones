﻿// <auto-generated />
using System;
using JumpsellerSync.DataAccess.Impl.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JumpsellerSync.DataAccess.Impl.Migrations.Tecnoglobal
{
    [DbContext(typeof(TecnoglobalNpgsqlDbContext))]
    [Migration("20201223160510_RemoveMaxLengthRestrictions")]
    partial class RemoveMaxLengthRestrictions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalBrand", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalConfiguration", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Configuration");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("BrandId")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("CurrencyType")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Mpn")
                        .HasColumnType("text");

                    b.Property<bool>("Offer")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RedcetusProductId")
                        .HasColumnType("text");

                    b.Property<double>("Stock")
                        .HasColumnType("double precision");

                    b.Property<string>("SubcategoryId")
                        .HasColumnType("text");

                    b.Property<double>("TecnoglobalDollar")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpcEan")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Mpn");

                    b.HasIndex("ProductCode")
                        .IsUnique();

                    b.HasIndex("RedcetusProductId")
                        .IsUnique();

                    b.HasIndex("SubcategoryId");

                    b.HasIndex("UpcEan");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalSubcategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalProduct", b =>
                {
                    b.HasOne("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalBrand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("JumpsellerSync.Domain.Impl.Tecnoglobal.TecnoglobalSubcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubcategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
