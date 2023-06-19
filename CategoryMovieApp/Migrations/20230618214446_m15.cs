using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    public partial class m15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Country",
                newName: "CountryNameTR");

            migrationBuilder.AddColumn<string>(
                name: "CountryNameEN",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryNameEN",
                table: "Country");

            migrationBuilder.RenameColumn(
                name: "CountryNameTR",
                table: "Country",
                newName: "CountryName");
        }
    }
}
