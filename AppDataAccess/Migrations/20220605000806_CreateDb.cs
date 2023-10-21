using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDataAccess.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depolars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADRES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CALISANSAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depolars", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musterilers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SOYADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TELEFON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADRES = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musterilers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MARKA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALISFIYAT = table.Column<int>(type: "int", nullable: false),
                    SATISFIYAT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depolars");

            migrationBuilder.DropTable(
                name: "Musterilers");

            migrationBuilder.DropTable(
                name: "Urunlers");
        }
    }
}
