﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wba.Assignments.web.Data;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    [DbContext(typeof(AssignmentDBContext))]
    [Migration("20240326122228_AddSeedingEmplyee")]
    partial class AddSeedingEmplyee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("AssignedEmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("AssignedProjectsId")
                        .HasColumnType("int");

                    b.HasKey("AssignedEmployeesId", "AssignedProjectsId");

                    b.HasIndex("AssignedProjectsId");

                    b.ToTable("EmployeeProject");
                });

            modelBuilder.Entity("wba.Assignments.core.entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7969),
                            Department = "IT",
                            Name = "Peter Van Damme",
                            Position = "Developer"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7975),
                            Department = "IT",
                            Name = "Lars Pollentier",
                            Position = "Analyst"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7977),
                            Department = "IT",
                            Name = "Wannes Vantorre",
                            Position = "Virtual machine specialist"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7978),
                            Department = "IT",
                            Name = "Kristof",
                            Position = "Developer"
                        });
                });

            modelBuilder.Entity("wba.Assignments.core.entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("wba.Assignments.core.entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("AssignedEmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wba.Assignments.core.entities.Project", null)
                        .WithMany()
                        .HasForeignKey("AssignedProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
