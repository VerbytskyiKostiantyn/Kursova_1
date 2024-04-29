using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_1.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "FirstName", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 4, "Львів вул. Липинського 22", new DateOnly(1993, 4, 4), null, new DateOnly(2021, 4, 1), "Олена", "Михайлова", "Програміст", 60000 },
                    { 5, "Харків вул. Франка 44", new DateOnly(1994, 5, 5), null, new DateOnly(2022, 5, 1), "Віктор", "Петренко", "Тестувальник", 55000 },
                    { 6, "Одеса вул. Лесі Українки 66", new DateOnly(1995, 6, 6), null, new DateOnly(2023, 6, 1), "Анастасія", "Коваленко", "Маркетолог", 45000 },
                    { 7, "Дніпро вул. Скоропадського 88", new DateOnly(1996, 7, 7), null, new DateOnly(2024, 7, 1), "Сергій", "Куліш", "HR-менеджер", 50000 },
                    { 8, "Запоріжжя вул. Шевченка 99", new DateOnly(1997, 8, 8), null, new DateOnly(2025, 8, 1), "Ірина", "Шевченко", "Фінансист", 40000 },
                    { 9, "Київ вул. Грушевського 11", new DateOnly(1998, 9, 9), null, new DateOnly(2026, 9, 1), "Василь", "Карпенко", "Системний адміністратор", 55000 },
                    { 10, "Львів вул. Франка 33", new DateOnly(1999, 10, 10), null, new DateOnly(2027, 10, 1), "Оксана", "Павленко", "Проектний менеджер", 60000 },
                    { 11, "Харків вул. Шевченка 55", new DateOnly(2000, 11, 11), null, new DateOnly(2028, 11, 1), "Олександр", "Кузьменко", "Бухгалтер", 45000 },
                    { 12, "Одеса вул. Скоропадського 77", new DateOnly(2001, 12, 12), null, new DateOnly(2029, 12, 1), "Юлія", "Михайлова", "HR-менеджер", 50000 },
                    { 13, "Дніпро вул. Шевченка 99", new DateOnly(2002, 1, 13), null, new DateOnly(2030, 1, 1), "Вікторія", "Коваленко", "Менеджер з продажів", 40000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
