using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionEventApi.Services.Migrations
{
    public partial class korekcijarelacija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_CompetitionEvents_CompetitionEventId",
                table: "CompetitionEvents");

            migrationBuilder.DropColumn(
                name: "CompetitionEventId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "CompetitionEventId",
                table: "CompetitionEvents");

            migrationBuilder.CreateTable(
                name: "RelatedEventCompetition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    CompetitionEventId = table.Column<int>(nullable: true),
                    CompetitionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedEventCompetition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedEventCompetition_CompetitionEvents_CompetitionEventId",
                        column: x => x.CompetitionEventId,
                        principalTable: "CompetitionEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RelatedEventCompetition_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelatedEventCompetition_CompetitionEventId",
                table: "RelatedEventCompetition",
                column: "CompetitionEventId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedEventCompetition_CompetitionId",
                table: "RelatedEventCompetition",
                column: "CompetitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatedEventCompetition");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionEventId",
                table: "Competitions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompetitionEventId",
                table: "CompetitionEvents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_CompetitionEventId",
                table: "Competitions",
                column: "CompetitionEventId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEvents_CompetitionEventId",
                table: "CompetitionEvents",
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
    }
}
