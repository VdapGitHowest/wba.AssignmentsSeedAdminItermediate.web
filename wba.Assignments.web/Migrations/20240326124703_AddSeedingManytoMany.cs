using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wba.Assignments.web.Migrations
{
    public partial class AddSeedingManytoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 47, 3, 106, DateTimeKind.Utc).AddTicks(2216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "AssignedEmployeesId", "AssignedProjectsId" },
                keyValues: new object[] { 4, 3 });

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 12, 35, 16, 432, DateTimeKind.Utc).AddTicks(7393));
        }
    }
}
