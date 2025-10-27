using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedOptionalSM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Matches_MatchId",
                table: "Schedules",
                column: "MatchId",
                principalTable: "Matches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
