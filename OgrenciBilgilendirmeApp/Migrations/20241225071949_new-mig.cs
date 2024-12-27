using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciBilgilendirmeApp.Migrations
{
    /// <inheritdoc />
    public partial class newmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ogrencilers_SinifId",
                table: "Ogrencilers",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDerslers_DersId",
                table: "OgrenciDerslers",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDerslers_Derslers_DersId",
                table: "OgrenciDerslers",
                column: "DersId",
                principalTable: "Derslers",
                principalColumn: "DersId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDerslers_Ogrencilers_OgrenciId",
                table: "OgrenciDerslers",
                column: "OgrenciId",
                principalTable: "Ogrencilers",
                principalColumn: "OgrenciId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrencilers_Siniflars_SinifId",
                table: "Ogrencilers",
                column: "SinifId",
                principalTable: "Siniflars",
                principalColumn: "SinifId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDerslers_Derslers_DersId",
                table: "OgrenciDerslers");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDerslers_Ogrencilers_OgrenciId",
                table: "OgrenciDerslers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrencilers_Siniflars_SinifId",
                table: "Ogrencilers");

            migrationBuilder.DropIndex(
                name: "IX_Ogrencilers_SinifId",
                table: "Ogrencilers");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciDerslers_DersId",
                table: "OgrenciDerslers");
        }
    }
}
