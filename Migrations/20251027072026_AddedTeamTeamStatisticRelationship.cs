using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedTeamTeamStatisticRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamStatistics",
                newName: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamStatistics_Teams_TeamId",
                table: "TeamStatistics",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamStatistics_Teams_TeamId",
                table: "TeamStatistics");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "TeamStatistics",
                newName: "Id");
        }
    }
}
