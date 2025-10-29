using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedTournamentTournamentResultRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "TournamentResults",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TournamentId",
                table: "TournamentResults",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TournamentResults_TeamId",
                table: "TournamentResults",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentResults_TournamentId",
                table: "TournamentResults",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentResults_Teams_TeamId",
                table: "TournamentResults",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TournamentResults_Tournaments_TournamentId",
                table: "TournamentResults",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TournamentResults_Teams_TeamId",
                table: "TournamentResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TournamentResults_Tournaments_TournamentId",
                table: "TournamentResults");

            migrationBuilder.DropIndex(
                name: "IX_TournamentResults_TeamId",
                table: "TournamentResults");

            migrationBuilder.DropIndex(
                name: "IX_TournamentResults_TournamentId",
                table: "TournamentResults");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "TournamentResults");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "TournamentResults");
        }
    }
}
