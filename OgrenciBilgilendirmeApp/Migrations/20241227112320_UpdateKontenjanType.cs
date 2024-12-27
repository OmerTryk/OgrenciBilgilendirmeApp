using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciBilgilendirmeApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKontenjanType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kontenjyan",
                table: "Siniflars");

            migrationBuilder.AddColumn<int>(
                name: "Kontenjan",
                table: "Siniflars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "OgrenciNumara",
                table: "Ogrencilers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DersKodu",
                table: "Derslers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kontenjan",
                table: "Siniflars");

            migrationBuilder.AddColumn<int>(
                name: "Kontenjyan",
                table: "Siniflars",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OgrenciNumara",
                table: "Ogrencilers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DersKodu",
                table: "Derslers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
