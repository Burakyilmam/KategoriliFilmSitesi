using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Years_YearId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Years",
                table: "Years");

            migrationBuilder.RenameTable(
                name: "Years",
                newName: "Year");

            migrationBuilder.AddColumn<bool>(
                name: "MovieStatu",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Year",
                table: "Year",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Year_YearId",
                table: "Movies",
                column: "YearId",
                principalTable: "Year",
                principalColumn: "YearId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Year_YearId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Year",
                table: "Year");

            migrationBuilder.DropColumn(
                name: "MovieStatu",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Year",
                newName: "Years");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Years",
                table: "Years",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Years_YearId",
                table: "Movies",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "YearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
