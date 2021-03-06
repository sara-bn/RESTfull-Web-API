﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDevSchoolApi.DbContexts;

namespace WebDevSchoolApi.Migrations
{
    [DbContext(typeof(SchoolProgramContext))]
    [Migration("20200627011433_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebDevSchoolApi.Entities.DevProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ClosestStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("DevPrograms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            ClosestStartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProgramName = "Software System Developer",
                            SchoolId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35")
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            ClosestStartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProgramName = "Full Stack Web Development",
                            SchoolId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96")
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            ClosestStartDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProgramName = "Web Development Bootcamp",
                            SchoolId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450")
                        });
                });

            modelBuilder.Entity("WebDevSchoolApi.Entities.School", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Address = "555 Seymour St, Vancouver, BC V6B 3H6",
                            SchoolName = "BCIT"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Address = "100 W 49th Ave, Vancouver, BC V5Y 2Z6",
                            SchoolName = "Langara"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Address = "401 W Georgia St, Vancouver, BC V6B 5A1",
                            SchoolName = "Lighthouse Labs"
                        });
                });

            modelBuilder.Entity("WebDevSchoolApi.Entities.DevProgram", b =>
                {
                    b.HasOne("WebDevSchoolApi.Entities.School", "School")
                        .WithMany("DevPrograms")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
