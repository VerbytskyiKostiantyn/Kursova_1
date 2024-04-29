﻿// <auto-generated />
using System;
using Kursova_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kursova_1.Migrations
{
    [DbContext(typeof(ManageEmployeesDbContext))]
    partial class ManageEmployeesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DateOfDismissal")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateOfEmployment")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                            DateOfEmployment = new DateOnly(2019, 3, 1),
                            FirstName = "Марія",
                            LastName = "Кузьменко",
                            Position = "Менеджер",
                            Salary = 30000
                        },
                        new
                        {
                            Id = 4,
                            Adress = "Львів вул. Липинського 22",
                            DateOfBirth = new DateOnly(1993, 4, 4),
                            DateOfEmployment = new DateOnly(2021, 4, 1),
                            FirstName = "Олена",
                            LastName = "Михайлова",
                            Position = "Програміст",
                            Salary = 60000
                        },
                        new
                        {
                            Id = 5,
                            Adress = "Харків вул. Франка 44",
                            DateOfBirth = new DateOnly(1994, 5, 5),
                            DateOfEmployment = new DateOnly(2022, 5, 1),
                            FirstName = "Віктор",
                            LastName = "Петренко",
                            Position = "Тестувальник",
                            Salary = 55000
                        },
                        new
                        {
                            Id = 6,
                            Adress = "Одеса вул. Лесі Українки 66",
                            DateOfBirth = new DateOnly(1995, 6, 6),
                            DateOfEmployment = new DateOnly(2023, 6, 1),
                            FirstName = "Анастасія",
                            LastName = "Коваленко",
                            Position = "Маркетолог",
                            Salary = 45000
                        },
                        new
                        {
                            Id = 7,
                            Adress = "Дніпро вул. Скоропадського 88",
                            DateOfBirth = new DateOnly(1996, 7, 7),
                            DateOfEmployment = new DateOnly(2024, 7, 1),
                            FirstName = "Сергій",
                            LastName = "Куліш",
                            Position = "HR-менеджер",
                            Salary = 50000
                        },
                        new
                        {
                            Id = 8,
                            Adress = "Запоріжжя вул. Шевченка 99",
                            DateOfBirth = new DateOnly(1997, 8, 8),
                            DateOfEmployment = new DateOnly(2025, 8, 1),
                            FirstName = "Ірина",
                            LastName = "Шевченко",
                            Position = "Фінансист",
                            Salary = 40000
                        },
                        new
                        {
                            Id = 9,
                            Adress = "Київ вул. Грушевського 11",
                            DateOfBirth = new DateOnly(1998, 9, 9),
                            DateOfEmployment = new DateOnly(2026, 9, 1),
                            FirstName = "Василь",
                            LastName = "Карпенко",
                            Position = "Системний адміністратор",
                            Salary = 55000
                        },
                        new
                        {
                            Id = 10,
                            Adress = "Львів вул. Франка 33",
                            DateOfBirth = new DateOnly(1999, 10, 10),
                            DateOfEmployment = new DateOnly(2027, 10, 1),
                            FirstName = "Оксана",
                            LastName = "Павленко",
                            Position = "Проектний менеджер",
                            Salary = 60000
                        },
                        new
                        {
                            Id = 11,
                            Adress = "Харків вул. Шевченка 55",
                            DateOfBirth = new DateOnly(2000, 11, 11),
                            DateOfEmployment = new DateOnly(2028, 11, 1),
                            FirstName = "Олександр",
                            LastName = "Кузьменко",
                            Position = "Бухгалтер",
                            Salary = 45000
                        },
                        new
                        {
                            Id = 12,
                            Adress = "Одеса вул. Скоропадського 77",
                            DateOfBirth = new DateOnly(2001, 12, 12),
                            DateOfEmployment = new DateOnly(2029, 12, 1),
                            FirstName = "Юлія",
                            LastName = "Михайлова",
                            Position = "HR-менеджер",
                            Salary = 50000
                        },
                        new
                        {
                            Id = 13,
                            Adress = "Дніпро вул. Шевченка 99",
                            DateOfBirth = new DateOnly(2002, 1, 13),
                            DateOfEmployment = new DateOnly(2030, 1, 1),
                            FirstName = "Вікторія",
                            LastName = "Коваленко",
                            Position = "Менеджер з продажів",
                            Salary = 40000
                        },
                        new
                        {
                            Id = 14,
                            Adress = "Київ вул. Грушевського 15",
                            DateOfBirth = new DateOnly(1991, 1, 14),
                            DateOfEmployment = new DateOnly(2021, 1, 14),
                            FirstName = "Олег",
                            LastName = "Петров",
                            Position = "Спеціаліст з IT",
                            Salary = 55000
                        },
                        new
                        {
                            Id = 15,
                            Adress = "Одеса вул. Шевченка 16",
                            DateOfBirth = new DateOnly(1992, 2, 15),
                            DateOfEmployment = new DateOnly(2022, 2, 15),
                            FirstName = "Анастасія",
                            LastName = "Коваленко",
                            Position = "Менеджер з продажів",
                            Salary = 45000
                        },
                        new
                        {
                            Id = 16,
                            Adress = "Дніпро вул. Скоропадського 17",
                            DateOfBirth = new DateOnly(1993, 3, 16),
                            DateOfEmployment = new DateOnly(2023, 3, 16),
                            FirstName = "Сергій",
                            LastName = "Куліш",
                            Position = "HR-менеджер",
                            Salary = 50000
                        },
                        new
                        {
                            Id = 17,
                            Adress = "Запоріжжя вул. Шевченка 18",
                            DateOfBirth = new DateOnly(1994, 4, 17),
                            DateOfEmployment = new DateOnly(2024, 4, 17),
                            FirstName = "Ірина",
                            LastName = "Шевченко",
                            Position = "Фінансист",
                            Salary = 40000
                        },
                        new
                        {
                            Id = 18,
                            Adress = "Київ вул. Грушевського 19",
                            DateOfBirth = new DateOnly(1995, 5, 18),
                            DateOfEmployment = new DateOnly(2025, 5, 18),
                            FirstName = "Василь",
                            LastName = "Карпенко",
                            Position = "Системний адміністратор",
                            Salary = 55000
                        },
                        new
                        {
                            Id = 19,
                            Adress = "Львів вул. Франка 19",
                            DateOfBirth = new DateOnly(1996, 6, 19),
                            DateOfEmployment = new DateOnly(2026, 6, 19),
                            FirstName = "Оксана",
                            LastName = "Павленко",
                            Position = "Проектний менеджер",
                            Salary = 60000
                        },
                        new
                        {
                            Id = 20,
                            Adress = "Харків вул. Шевченка 19",
                            DateOfBirth = new DateOnly(1997, 7, 20),
                            DateOfEmployment = new DateOnly(2027, 7, 20),
                            FirstName = "Олександр",
                            LastName = "Кузьменко",
                            Position = "Бухгалтер",
                            Salary = 45000
                        },
                        new
                        {
                            Id = 21,
                            Adress = "Одеса вул. Скоропадського 19",
                            DateOfBirth = new DateOnly(1998, 8, 21),
                            DateOfEmployment = new DateOnly(2028, 8, 21),
                            FirstName = "Юлія",
                            LastName = "Михайлова",
                            Position = "HR-менеджер",
                            Salary = 50000
                        },
                        new
                        {
                            Id = 22,
                            Adress = "Дніпро вул. Шевченка 19",
                            DateOfBirth = new DateOnly(1999, 9, 22),
                            DateOfEmployment = new DateOnly(2029, 9, 22),
                            FirstName = "Вікторія",
                            LastName = "Коваленко",
                            Position = "Менеджер з продажів",
                            Salary = 40000
                        },
                        new
                        {
                            Id = 23,
                            Adress = "Львів вул. Липинського 23",
                            DateOfBirth = new DateOnly(2000, 10, 23),
                            DateOfEmployment = new DateOnly(2030, 10, 23),
                            FirstName = "Олена",
                            LastName = "Михайлова",
                            Position = "Програміст",
                            Salary = 60000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
