﻿// <auto-generated />
using System;
using FlightLibrairy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlightLibrairy.Migrations
{
    [DbContext(typeof(VolContext))]
    [Migration("20200413183451_initial migration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FlightLibrairy.Models.VolEntite", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AeroportArrivee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AeroportDepart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateArrivee")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDepart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalTravelTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vols");
                });
#pragma warning restore 612, 618
        }
    }
}
