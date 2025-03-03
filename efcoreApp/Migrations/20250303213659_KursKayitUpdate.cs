using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcoreApp.Migrations
{
    /// <inheritdoc />
    public partial class KursKayitUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgreniId",
                table: "KursKayitlari",
                newName: "OgrenciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OgrenciId",
                table: "KursKayitlari",
                newName: "OgreniId");
        }
    }
}
