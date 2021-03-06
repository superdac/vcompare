﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VCompare.Persistence;

namespace VCompare.Persistence.Migrations
{
    [DbContext(typeof(VCompareDbContext))]
    partial class VCompareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("VCompare.Domain.Entities.PriceCalculationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("Base");

                    b.Property<int?>("Limit");

                    b.Property<decimal>("PricePerKWH");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("PriceCalculationModels");
                });

            modelBuilder.Entity("VCompare.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VCompare.Domain.Entities.PriceCalculationModel", b =>
                {
                    b.HasOne("VCompare.Domain.Entities.Product", "Product")
                        .WithOne("PriceCalculationModel")
                        .HasForeignKey("VCompare.Domain.Entities.PriceCalculationModel", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
