using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CommentStatu",
                table: "Comment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CategoryStatu",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentStatu",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CategoryStatu",
                table: "Categories");
        }
    }
}
