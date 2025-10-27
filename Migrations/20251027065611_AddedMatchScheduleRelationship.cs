using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedMatchScheduleRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MatchId",
                table: "Schedules",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_MatchId",
                table: "Schedules",
                column: "MatchId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_MatchId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Schedules");
        }
    }
}
