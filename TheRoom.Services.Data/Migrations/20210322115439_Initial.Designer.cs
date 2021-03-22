﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheRoom.Services.Data;

namespace TheRoom.Services.Data.Migrations
{
    [DbContext(typeof(ServiceContext))]
    [Migration("20210322115439_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheRoom.Services.Domain.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromoCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceID = 1,
                            Description = "Sitecostructor.io",
                            PromoCode = "itpromocodes"
                        },
                        new
                        {
                            ServiceID = 2,
                            Description = "AppVision.com",
                            PromoCode = "itpromocodes"
                        },
                        new
                        {
                            ServiceID = 3,
                            Description = "Analytics.com",
                            PromoCode = "itpromocodes"
                        },
                        new
                        {
                            ServiceID = 4,
                            Description = "Logotype",
                            PromoCode = "itpromocodes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
