using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeridiaAPI.Migrations
{
    public partial class NpcContextv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accomplishments",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Accomplishments",
                columns: new[] { "Id", "DateOfAccomplishment", "Name", "PersonId" },
                values: new object[] { 1, new DateTime(2020, 4, 19, 0, 50, 20, 383, DateTimeKind.Local).AddTicks(833), "Graduate College", 1 });

            migrationBuilder.InsertData(
                table: "Accomplishments",
                columns: new[] { "Id", "DateOfAccomplishment", "Name", "PersonId" },
                values: new object[] { 2, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graduate Jr High", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accomplishments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accomplishments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Accomplishments",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);
        }
    }
}
