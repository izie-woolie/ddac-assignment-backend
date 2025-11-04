using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDACAssignment.Migrations
{
    /// <inheritdoc />
    public partial class AddedRequestAndItsChildren : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Personnels_PersonnelProfileId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Applies");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonnelProfileId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PersonnelProfileId",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    OrganizationName = table.Column<string>(type: "text", nullable: true),
                    RequestedRole = table.Column<string>(type: "text", nullable: true),
                    TeamName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Users_Id",
                table: "Personnels",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Users_Id",
                table: "Personnels");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonnelProfileId",
                table: "Users",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Applies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RequestedRole = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applies", x => x.Id);
                });

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
    }
}
