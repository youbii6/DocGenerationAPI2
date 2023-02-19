using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocGenerationAPI2.Migrations
{
    public partial class MoreSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceLines_Invoices_InvoiceId",
                table: "InvoiceLines");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "InvoiceLines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "ClientId", "CreationDate", "Name" },
                values: new object[] { 1, 1, new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9543), "invoice 1" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "ClientId", "CreationDate", "Name" },
                values: new object[] { 2, 1, new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9545), "invoice 2" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "ClientId", "CreationDate", "Name" },
                values: new object[] { 3, 2, new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9546), "invoice 3" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "ClientId", "CreationDate", "Name" },
                values: new object[] { 4, 2, new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9547), "invoice 4" });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "ClientId", "CreationDate", "Name" },
                values: new object[] { 5, 3, new DateTime(2023, 2, 15, 15, 46, 11, 747, DateTimeKind.Utc).AddTicks(9548), "invoice 5" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 1, 30, "Provider x" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 2, 40, "Provider x" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 3, 30, "Provider y" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 4, 40, "Provider y" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 5, 20, "Provider z" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Price", "Provider" },
                values: new object[] { 6, 85, "Provider z" });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 1, 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 2, 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 3, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 4, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 5, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 6, 2, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 7, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 8, 3, 2, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceLines_Invoices_InvoiceId",
                table: "InvoiceLines",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceLines_Invoices_InvoiceId",
                table: "InvoiceLines");

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "InvoiceLines",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceLines_Invoices_InvoiceId",
                table: "InvoiceLines",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");
        }
    }
}
