using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocGenerationAPI2.Migrations
{
    public partial class la7thet_el_ha9i9a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 25, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 26, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 27, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 28, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 29, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 30, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 31, 3, 2, 1 });

            migrationBuilder.InsertData(
                table: "InvoiceLines",
                columns: new[] { "Id", "InvoiceId", "Qte", "ServiceId" },
                values: new object[] { 32, 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 3, 3, 10, 12, 57, 407, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 3, 3, 10, 12, 57, 407, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 3, 3, 10, 12, 57, 407, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 3, 3, 10, 12, 57, 407, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 3, 3, 10, 12, 57, 407, DateTimeKind.Utc).AddTicks(3586));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "InvoiceLines",
                keyColumn: "Id",
                keyValue: 32);

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
    }
}
