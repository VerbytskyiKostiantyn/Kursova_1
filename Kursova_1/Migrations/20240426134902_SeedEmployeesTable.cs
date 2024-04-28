using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kursova_1.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployeesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Adress", "DateOfBirth", "DateOfDismissal", "DateOfEmployment", "FirstName", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "Київ вул. Шевченка 13", new DateOnly(1990, 1, 1), new DateOnly(1, 1, 1), new DateOnly(2020, 1, 1), "Андрій", "Романов", "Адміністратор", 50000 },
                    { 2, "Київ вул. Лесі Українки 67", new DateOnly(1992, 2, 2), new DateOnly(1, 1, 1), new DateOnly(2020, 2, 1), "Роман", "Денисенко", "Дизайнер", 40000 },
                    { 3, "Київ вул. Шевченка 56", new DateOnly(1985, 3, 3), new DateOnly(1, 1, 1), new DateOnly(2019, 3, 1), "Марія", "Кузьменко", "Менеджер", 30000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
