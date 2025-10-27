using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlayerPlayerPerformanceRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PlayerPerformances",
                newName: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPerformances_Players_PlayerId",
                table: "PlayerPerformances",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPerformances_Players_PlayerId",
                table: "PlayerPerformances");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "PlayerPerformances",
                newName: "Id");
        }
    }
}
