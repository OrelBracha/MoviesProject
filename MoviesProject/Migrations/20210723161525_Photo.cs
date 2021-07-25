using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesProject.Migrations
{
    public partial class Photo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
