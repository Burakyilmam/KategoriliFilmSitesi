using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    public partial class m16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieBadge",
                table: "Movies",
                newName: "MovieBadgeTR");

            migrationBuilder.AddColumn<string>(
                name: "MovieBadgeEN",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieBadgeEN",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieBadgeTR",
                table: "Movies",
                newName: "MovieBadge");
        }
    }
}
