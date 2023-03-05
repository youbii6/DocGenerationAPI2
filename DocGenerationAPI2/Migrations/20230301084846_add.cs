using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocGenerationAPI2.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 9, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 10, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 11, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 12, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 13, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 14, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 15, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 16, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 17, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 18, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 19, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 20, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 21, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 22, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 23, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 24, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 3, 1, 8, 48, 45, 706, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 3, 1, 8, 48, 45, 706, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 3, 1, 8, 48, 45, 706, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 3, 1, 8, 48, 45, 706, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 3, 1, 8, 48, 45, 706, DateTimeKind.Utc).AddTicks(9423));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 24);

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
    }
}
