﻿// <auto-generated />
using System;
using AIROPORT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AIROPORT.Migrations
{
    [DbContext(typeof(AIROPORTContext))]
    [Migration("20201024093352_Init3")]
    partial class Init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BD_AIROPORT.Models.Crews", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CodeStaf1ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CodeStaf2ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CodeStaf3ID")
                        .HasColumnType("bigint");

                    b.Property<string>("HourceFlown")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Crew");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.Planes", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapacityPassengers")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatelastRepair")
                        .HasColumnType("datetime2");

                    b.Property<int>("HourceFlown")
                        .HasColumnType("int");

                    b.Property<string>("PlaneMark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Staff_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("TechnicalParameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tonnage")
                        .HasColumnType("int");

                    b.Property<long?>("TypePlane_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.Positions", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<long?>("StaffsID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("StaffsID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.Staffs", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long?>("CrewsID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrewsID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("CrewsID2")
                        .HasColumnType("bigint");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStaff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PlanesID")
                        .HasColumnType("bigint");

                    b.Property<long?>("position_ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CrewsID");

                    b.HasIndex("CrewsID1");

                    b.HasIndex("CrewsID2");

                    b.HasIndex("PlanesID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.TypePlanes", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DestinationPlane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamePlane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PlanesID")
                        .HasColumnType("bigint");

                    b.Property<string>("limitationsPlane")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PlanesID");

                    b.ToTable("TypePlanes");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.Positions", b =>
                {
                    b.HasOne("BD_AIROPORT.Models.Staffs", null)
                        .WithMany("position")
                        .HasForeignKey("StaffsID");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.Staffs", b =>
                {
                    b.HasOne("BD_AIROPORT.Models.Crews", null)
                        .WithMany("Staff1")
                        .HasForeignKey("CrewsID");

                    b.HasOne("BD_AIROPORT.Models.Crews", null)
                        .WithMany("Staff2")
                        .HasForeignKey("CrewsID1");

                    b.HasOne("BD_AIROPORT.Models.Crews", null)
                        .WithMany("Staff3")
                        .HasForeignKey("CrewsID2");

                    b.HasOne("BD_AIROPORT.Models.Planes", null)
                        .WithMany("Staff")
                        .HasForeignKey("PlanesID");
                });

            modelBuilder.Entity("BD_AIROPORT.Models.TypePlanes", b =>
                {
                    b.HasOne("BD_AIROPORT.Models.Planes", null)
                        .WithMany("TypePlane")
                        .HasForeignKey("PlanesID");
                });
#pragma warning restore 612, 618
        }
    }
}
