using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocGenerationAPI2.Migrations
{
    public partial class yeh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 2, 16, 10, 14, 11, 323, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 2, 16, 10, 14, 11, 323, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 2, 16, 10, 14, 11, 323, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 2, 16, 10, 14, 11, 323, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 2, 16, 10, 14, 11, 323, DateTimeKind.Utc).AddTicks(1644));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9548));
        }
    }
}
