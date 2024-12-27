using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciBilgilendirmeApp.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Derslers",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DersKodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslers", x => x.DersId);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDerslers",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDerslers", x => new { x.OgrenciId, x.DersId });
                });

            migrationBuilder.CreateTable(
                name: "Ogrencilers",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgrenciNumara = table.Column<int>(type: "int", nullable: true),
                    SinifId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencilers", x => x.OgrenciId);
                });

            migrationBuilder.CreateTable(
                name: "Siniflars",
                columns: table => new
                {
                    SinifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontenjyan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflars", x => x.SinifId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Derslers");

            migrationBuilder.DropTable(
                name: "OgrenciDerslers");

            migrationBuilder.DropTable(
                name: "Ogrencilers");

            migrationBuilder.DropTable(
                name: "Siniflars");
        }
    }
}
