using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionEventApi.Services.Migrations
{
    public partial class korekcijarelacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEvents_Competitions_CompetitionId",
                table: "CompetitionEvents");

            migrationBuilder.RenameColumn(
                name: "CompetitionId",
                table: "CompetitionEvents",
                newName: "CompetitionEventId");

            migrationBuilder.RenameIndex(
                name: "IX_CompetitionEvents_CompetitionId",
                table: "CompetitionEvents",
                newName: "IX_CompetitionEvents_CompetitionEventId");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionEventId",
                table: "Competitions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CompetitionEventId",
                table: "Competitions",
                column: "CompetitionEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEvents_CompetitionEvents_CompetitionEventId",
                table: "CompetitionEvents",
                column: "CompetitionEventId",
                principalTable: "CompetitionEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_CompetitionEvents_CompetitionEventId",
                table: "Competitions",
                column: "CompetitionEventId",
                principalTable: "CompetitionEvents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitionEvents_CompetitionEvents_CompetitionEventId",
                table: "CompetitionEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_CompetitionEvents_CompetitionEventId",
                table: "Competitions");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_CompetitionEventId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "CompetitionEventId",
                table: "Competitions");

            migrationBuilder.RenameColumn(
                name: "CompetitionEventId",
                table: "CompetitionEvents",
                newName: "CompetitionId");

            migrationBuilder.RenameIndex(
                name: "IX_CompetitionEvents_CompetitionEventId",
                table: "CompetitionEvents",
                newName: "IX_CompetitionEvents_CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitionEvents_Competitions_CompetitionId",
                table: "CompetitionEvents",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
