using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionEventApi.Services.Migrations
{
    public partial class clubname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClubName",
                table: "Contestants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClubName",
                table: "Contestants");
        }
    }
}
