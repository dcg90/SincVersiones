﻿// <auto-generated />
using System;
using JumpsellerSync.DataAccess.Impl.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JumpsellerSync.DataAccess.Impl.Migrations.Main
{
    [DbContext(typeof(MainNpgsqlDbContext))]
    [Migration("20201002024822_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Brand", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ProviderBrandId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProviderBrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<string>("ProviderCategoryId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProviderCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("BrandId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Format")
                        .HasColumnType("integer");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsDigital")
                        .HasColumnType("boolean");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("SKU")
                        .HasColumnType("text");

                    b.Property<double>("Stock")
                        .HasColumnType("double precision");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Provider", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("NextSynchronization")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("SynchronizationType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Priority")
                        .IsUnique();

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Provider");

                    b.HasDiscriminator<string>("SynchronizationType").HasValue("Provider");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.HourlyProvider", b =>
                {
                    b.HasBaseType("JumpsellerSync.Domain.Impl.Main.Provider");

                    b.HasDiscriminator().HasValue("Hourly");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.PeriodicallyProvider", b =>
                {
                    b.HasBaseType("JumpsellerSync.Domain.Impl.Main.Provider");

                    b.Property<int>("Interval")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("interval");

                    b.HasDiscriminator().HasValue("Periodically");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Category", b =>
                {
                    b.HasOne("JumpsellerSync.Domain.Impl.Main.Product", null)
                        .WithMany("Categories")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.Product", b =>
                {
                    b.HasOne("JumpsellerSync.Domain.Impl.Main.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("JumpsellerSync.Domain.Impl.Main.HourlyProvider", b =>
                {
                    b.OwnsMany("JumpsellerSync.Domain.Impl.Main.Hour", "Hours", b1 =>
                        {
                            b1.Property<int>("HourId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("HourlyProviderId")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<TimeSpan>("Time")
                                .HasColumnType("interval");

                            b1.HasKey("HourId");

                            b1.HasIndex("HourlyProviderId");

                            b1.ToTable("Hour");

                            b1.WithOwner()
                                .HasForeignKey("HourlyProviderId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
