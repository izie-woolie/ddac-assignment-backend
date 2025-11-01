using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class RefactorPersonnel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_UserId",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Personnels");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonnelProfileId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonnelProfileId",
                table: "Users",
                column: "PersonnelProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Personnels_PersonnelProfileId",
                table: "Users",
                column: "PersonnelProfileId",
                principalTable: "Personnels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Personnels_PersonnelProfileId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonnelProfileId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonnelProfileId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Personnels",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_UserId",
                table: "Personnels",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Users_UserId",
                table: "Personnels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
