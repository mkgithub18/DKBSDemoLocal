﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReposirotyPatternDemo;

namespace ReposirotyPatternDemo.Migrations
{
    [DbContext(typeof(DkbsContext))]
    [Migration("20190309102539_DKBSDatabase")]
    partial class DKBSDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReposirotyPatternDemo.Customer", b =>
                {
                    b.Property<decimal>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Name");

                    b.Property<string>("OrderName");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 100m,
                            Name = "Hindustan Liver",
                            OrderName = "Dettol"
                        },
                        new
                        {
                            CustomerId = 101m,
                            Name = "Emami",
                            OrderName = "Savlon"
                        },
                        new
                        {
                            CustomerId = 102m,
                            Name = "Boro Plus",
                            OrderName = "Sheeter"
                        });
                });

            modelBuilder.Entity("ReposirotyPatternDemo.Partner", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartnerName");

                    b.Property<int>("ZipCode");

                    b.HasKey("PartnerId");

                    b.ToTable("Partners");

                    b.HasData(
                        new
                        {
                            PartnerId = 200,
                            PartnerName = "White feather",
                            ZipCode = 482001
                        },
                        new
                        {
                            PartnerId = 201,
                            PartnerName = "Blak Panther",
                            ZipCode = 144211
                        },
                        new
                        {
                            PartnerId = 202,
                            PartnerName = "Hinduja",
                            ZipCode = 560076
                        });
                });
#pragma warning restore 612, 618
        }
    }
}