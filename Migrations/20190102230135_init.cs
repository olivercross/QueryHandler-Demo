using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QueryHandler.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    AuditState = table.Column<int>(nullable: false),
                    AuditType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "Id", "AuditState", "AuditType", "DateCreated" },
                values: new object[] { 1, 0, "Default", new DateTime(2019, 1, 2, 23, 1, 35, 52, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "Id", "AuditState", "AuditType", "DateCreated" },
                values: new object[] { 2, 0, "section 1", new DateTime(2019, 1, 1, 23, 1, 35, 55, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.InsertData(
                table: "Audit",
                columns: new[] { "Id", "AuditState", "AuditType", "DateCreated" },
                values: new object[] { 3, 0, "Default", new DateTime(2018, 12, 31, 23, 1, 35, 55, DateTimeKind.Local).AddTicks(210) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audit");
        }
    }
}
