using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionEventApi.Services.Migrations
{
    public partial class emailMob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contestants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mob",
                table: "Contestants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contestants");

            migrationBuilder.DropColumn(
                name: "Mob",
                table: "Contestants");
        }
    }
}
