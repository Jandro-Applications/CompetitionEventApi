using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionEventApi.Services.Migrations
{
    public partial class competitionscoreCompetition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "CompetitionScore",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionScore_CompetitionId",
                table: "CompetitionScore",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionScore_Competitions_CompetitionId",
                table: "CompetitionScore",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionScore_Competitions_CompetitionId",
                table: "CompetitionScore");

            migrationBuilder.DropIndex(
                name: "IX_CompetitionScore_CompetitionId",
                table: "CompetitionScore");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "CompetitionScore");
        }
    }
}
