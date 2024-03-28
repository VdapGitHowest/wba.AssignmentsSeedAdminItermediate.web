using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingEmplyee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Created", "Deleted", "Department", "Name", "Position" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7969), null, "IT", "Peter Van Damme", "Developer" },
                    { 2, new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7975), null, "IT", "Lars Pollentier", "Analyst" },
                    { 3, new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7977), null, "IT", "Wannes Vantorre", "Virtual machine specialist" },
                    { 4, new DateTime(2024, 3, 26, 12, 22, 28, 100, DateTimeKind.Utc).AddTicks(7978), null, "IT", "Kristof", "Developer" }
                });
        }

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

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
