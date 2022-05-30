using Microsoft.EntityFrameworkCore.Migrations;

namespace TestPowtorka.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autorzy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorzy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ksiazki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    AutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ksiazki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ksiazki_Autorzy_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autorzy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autorzy",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Jacek", "Kowal" },
                    { 2, "Franek", "Janosik" },
                    { 3, "Michał", "Nowak" },
                    { 4, "Bolesław", "Prus" }
                });

            migrationBuilder.InsertData(
                table: "Ksiazki",
                columns: new[] { "Id", "AutorId", "Description", "NumberOfPages", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Horror z grozą", 100, "Groza" },
                    { 2, 2, "Zimno", 150, "Mroz" },
                    { 3, 3, "Dobra ksiazka", 200, "Pretty Woman" },
                    { 5, 3, "Zabawka dla dzieci", 200, "Lalka" },
                    { 4, 4, "Dużo wody", 300, "Potop" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ksiazki_AutorId",
                table: "Ksiazki",
                column: "AutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ksiazki");

            migrationBuilder.DropTable(
                name: "Autorzy");
        }
    }
}
