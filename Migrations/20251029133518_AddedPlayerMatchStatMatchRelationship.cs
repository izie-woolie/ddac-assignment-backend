using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlayerMatchStatMatchRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MatchId",
                table: "PlayerMatchStats",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "PlayerId",
                table: "PlayerMatchStats",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "PlayerMatchStats",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchStats_MatchId",
                table: "PlayerMatchStats",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchStats_PlayerId",
                table: "PlayerMatchStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchStats_TeamId",
                table: "PlayerMatchStats",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerMatchStats_Matches_MatchId",
                table: "PlayerMatchStats",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerMatchStats_Players_PlayerId",
                table: "PlayerMatchStats",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerMatchStats_Teams_TeamId",
                table: "PlayerMatchStats",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerMatchStats_Matches_MatchId",
                table: "PlayerMatchStats");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerMatchStats_Players_PlayerId",
                table: "PlayerMatchStats");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerMatchStats_Teams_TeamId",
                table: "PlayerMatchStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerMatchStats_MatchId",
                table: "PlayerMatchStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerMatchStats_PlayerId",
                table: "PlayerMatchStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerMatchStats_TeamId",
                table: "PlayerMatchStats");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "PlayerMatchStats");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerMatchStats");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "PlayerMatchStats");
        }
    }
}
