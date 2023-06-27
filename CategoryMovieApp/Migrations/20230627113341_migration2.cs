using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CategoryMovieApp.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crew");

            migrationBuilder.DropColumn(
                name: "ContactAddres",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactMail",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Contacts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactAddres",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactMail",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    CrewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    CrewGithub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrewImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrewLinkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrewName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CrewStatu = table.Column<bool>(type: "bit", nullable: false),
                    CrewTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.CrewId);
                    table.ForeignKey(
                        name: "FK_Crew_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crew_ContactId",
                table: "Crew",
                column: "ContactId");
        }
    }
}
