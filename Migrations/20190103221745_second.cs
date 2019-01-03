using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QueryHandler.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2019, 1, 3, 22, 17, 45, 483, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2019, 1, 2, 22, 17, 45, 486, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2019, 1, 1, 22, 17, 45, 486, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "Id", "AuditState", "AuditType", "DateCreated" },
                values: new object[] { 4, 1, "Default", new DateTime(2018, 12, 31, 22, 17, 45, 486, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "Id", "AuditState", "AuditType", "DateCreated" },
                values: new object[] { 5, 0, "Default", new DateTime(2018, 12, 30, 22, 17, 45, 486, DateTimeKind.Local).AddTicks(3930) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2019, 1, 2, 23, 1, 35, 52, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2019, 1, 1, 23, 1, 35, 55, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Audit",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 12, 31, 23, 1, 35, 55, DateTimeKind.Local).AddTicks(210));
        }
    }
}
