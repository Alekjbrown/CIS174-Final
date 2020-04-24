using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VeridiaAPI.Migrations
{
    public partial class NpcContextv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accomplishments");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "City",
                table: "People");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "People");

            migrationBuilder.DropColumn(
                name: "State",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cha",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Con",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "People",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dex",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "People",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Int",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "People",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "People",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "People",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Str",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wis",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Gender", "Name", "Race" },
                values: new object[] { "Female", "Alianor", "Human" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Gender", "Name", "Race" },
                values: new object[] { "Female", "Ashtyn Briarlore", "Naina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Cha",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Con",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Dex",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Int",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Str",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Wis",
                table: "People");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "People",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "People",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "People",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "People",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "People",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Accomplishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfAccomplishment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomplishments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accomplishments_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accomplishments",
                columns: new[] { "Id", "DateOfAccomplishment", "Name", "PersonId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 19, 0, 50, 20, 383, DateTimeKind.Local).AddTicks(833), "Graduate College", 1 },
                    { 2, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graduate Jr High", 2 }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alek", "Brown" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shea", "Brown" });

            migrationBuilder.CreateIndex(
                name: "IX_Accomplishments_PersonId",
                table: "Accomplishments",
                column: "PersonId");
        }
    }
}
