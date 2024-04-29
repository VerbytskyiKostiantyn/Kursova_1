using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_1.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeed2EmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "FirstName", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 14, "Київ вул. Грушевського 15", new DateOnly(1991, 1, 14), null, new DateOnly(2021, 1, 14), "Олег", "Петров", "Спеціаліст з IT", 55000 },
                    { 15, "Одеса вул. Шевченка 16", new DateOnly(1992, 2, 15), null, new DateOnly(2022, 2, 15), "Анастасія", "Коваленко", "Менеджер з продажів", 45000 },
                    { 16, "Дніпро вул. Скоропадського 17", new DateOnly(1993, 3, 16), null, new DateOnly(2023, 3, 16), "Сергій", "Куліш", "HR-менеджер", 50000 },
                    { 17, "Запоріжжя вул. Шевченка 18", new DateOnly(1994, 4, 17), null, new DateOnly(2024, 4, 17), "Ірина", "Шевченко", "Фінансист", 40000 },
                    { 18, "Київ вул. Грушевського 19", new DateOnly(1995, 5, 18), null, new DateOnly(2025, 5, 18), "Василь", "Карпенко", "Системний адміністратор", 55000 },
                    { 19, "Львів вул. Франка 19", new DateOnly(1996, 6, 19), null, new DateOnly(2026, 6, 19), "Оксана", "Павленко", "Проектний менеджер", 60000 },
                    { 20, "Харків вул. Шевченка 19", new DateOnly(1997, 7, 20), null, new DateOnly(2027, 7, 20), "Олександр", "Кузьменко", "Бухгалтер", 45000 },
                    { 21, "Одеса вул. Скоропадського 19", new DateOnly(1998, 8, 21), null, new DateOnly(2028, 8, 21), "Юлія", "Михайлова", "HR-менеджер", 50000 },
                    { 22, "Дніпро вул. Шевченка 19", new DateOnly(1999, 9, 22), null, new DateOnly(2029, 9, 22), "Вікторія", "Коваленко", "Менеджер з продажів", 40000 },
                    { 23, "Львів вул. Липинського 23", new DateOnly(2000, 10, 23), null, new DateOnly(2030, 10, 23), "Олена", "Михайлова", "Програміст", 60000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
