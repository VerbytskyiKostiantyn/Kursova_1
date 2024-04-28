﻿// <auto-generated />
using System;
using Kursova_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kursova_1.Migrations
{
    [DbContext(typeof(ManageEmployeesDbContext))]
    [Migration("20240426134902_SeedEmployeesTable")]
    partial class SeedEmployeesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kursova_1.Models.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfDismissal")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfEmployment")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Київ вул. Шевченка 13",
                            DateOfBirth = new DateOnly(1990, 1, 1),
                            DateOfDismissal = new DateOnly(1, 1, 1),
                            DateOfEmployment = new DateOnly(2020, 1, 1),
                            FirstName = "Андрій",
                            LastName = "Романов",
                            Position = "Адміністратор",
                            Salary = 50000
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Київ вул. Лесі Українки 67",
                            DateOfBirth = new DateOnly(1992, 2, 2),
                            DateOfDismissal = new DateOnly(1, 1, 1),
                            DateOfEmployment = new DateOnly(2020, 2, 1),
                            FirstName = "Роман",
                            LastName = "Денисенко",
                            Position = "Дизайнер",
                            Salary = 40000
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Київ вул. Шевченка 56",
                            DateOfBirth = new DateOnly(1985, 3, 3),
                            DateOfDismissal = new DateOnly(1, 1, 1),
                            DateOfEmployment = new DateOnly(2019, 3, 1),
                            FirstName = "Марія",
                            LastName = "Кузьменко",
                            Position = "Менеджер",
                            Salary = 30000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
