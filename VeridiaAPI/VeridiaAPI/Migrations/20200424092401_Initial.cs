using Microsoft.EntityFrameworkCore.Migrations;

namespace VeridiaAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "npcs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 25, nullable: false),
                    Gender = table.Column<string>(maxLength: 25, nullable: false),
                    Race = table.Column<string>(maxLength: 25, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    Notes = table.Column<string>(maxLength: 300, nullable: true),
                    Str = table.Column<int>(nullable: false),
                    Dex = table.Column<int>(nullable: false),
                    Con = table.Column<int>(nullable: false),
                    Int = table.Column<int>(nullable: false),
                    Wis = table.Column<int>(nullable: false),
                    Cha = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_npcs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "npcs",
                columns: new[] { "Id", "Age", "Cha", "Con", "Description", "Dex", "Gender", "Int", "Name", "Notes", "Race", "Str", "Wis" },
                values: new object[] { 1, 0, 0, 0, null, 0, "Female", 0, "Alianor", null, "Human", 0, 0 });

            migrationBuilder.InsertData(
                table: "npcs",
                columns: new[] { "Id", "Age", "Cha", "Con", "Description", "Dex", "Gender", "Int", "Name", "Notes", "Race", "Str", "Wis" },
                values: new object[] { 2, 0, 0, 0, null, 0, "Female", 0, "Ashtyn Briarlore", null, "Naina", 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "npcs");
        }
    }
}
