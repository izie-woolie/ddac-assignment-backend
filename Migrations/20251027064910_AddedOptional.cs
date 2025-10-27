using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizers_Users_UserId",
                table: "Organizers");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizers_Users_UserId",
                table: "Organizers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organizers_Users_UserId",
                table: "Organizers");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.AddForeignKey(
                name: "FK_Organizers_Users_UserId",
                table: "Organizers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
