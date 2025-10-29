using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchRoundRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MatchId",
                table: "Rounds",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_MatchId",
                table: "Rounds",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Matches_MatchId",
                table: "Rounds",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Matches_MatchId",
                table: "Rounds");

            migrationBuilder.DropIndex(
                name: "IX_Rounds_MatchId",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Rounds");
        }
    }
}
