using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Ambulator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Hekim_GonderenId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Hekim_HekimId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_MuracietSebebi_MuracietSebebiId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorXidmet_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_GonderenId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_HekimId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_MuracietSebebiId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropColumn(
                name: "GonderenId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "HekimId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "MuracietSebebiId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.AddColumn<int>(
                name: "GonderenId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_GonderenId",
                table: "AmbulatorXidmet",
                column: "GonderenId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Hekim_GonderenId",
                table: "AmbulatorXidmet",
                column: "GonderenId",
                principalTable: "Hekim",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Hekim_GonderenId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorXidmet_GonderenId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropColumn(
                name: "GonderenId",
                table: "AmbulatorXidmet");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GonderenId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HekimId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MuracietSebebiId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_UserId",
                table: "AmbulatorXidmet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_GonderenId",
                table: "AmbulatorMuraciet",
                column: "GonderenId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_HekimId",
                table: "AmbulatorMuraciet",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_MuracietSebebiId",
                table: "AmbulatorMuraciet",
                column: "MuracietSebebiId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Hekim_GonderenId",
                table: "AmbulatorMuraciet",
                column: "GonderenId",
                principalTable: "Hekim",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Hekim_HekimId",
                table: "AmbulatorMuraciet",
                column: "HekimId",
                principalTable: "Hekim",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_MuracietSebebi_MuracietSebebiId",
                table: "AmbulatorMuraciet",
                column: "MuracietSebebiId",
                principalTable: "MuracietSebebi",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}