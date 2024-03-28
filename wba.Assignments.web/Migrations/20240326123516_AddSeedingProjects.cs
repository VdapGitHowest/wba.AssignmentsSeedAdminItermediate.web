using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Created", "Deleted", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7390), null, "Redesining the company website to improve AI capabilities", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Website Redesign", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7392), null, "Launching a new product with expensive marketing campaign", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product launch", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7393), null, "Implementing a training program for employees to enhance skills and productivity.", new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internal Training Program", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 31, 56, 677, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 31, 56, 677, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 31, 56, 677, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 31, 56, 677, DateTimeKind.Utc).AddTicks(6437));
        }
    }
}
