using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedTeamPersonnelRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TeamId",
                table: "Personnels",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_TeamId",
                table: "Personnels",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Teams_TeamId",
                table: "Personnels",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Teams_TeamId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_TeamId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Personnels");
        }
    }
}
