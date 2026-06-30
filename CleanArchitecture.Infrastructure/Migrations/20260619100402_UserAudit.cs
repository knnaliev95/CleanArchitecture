using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateUserId",
                table: "Users",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DeleteUserId",
                table: "Users",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreateUserId",
                table: "Users",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleteUserId",
                table: "Users",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreateUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleteUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreateUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DeleteUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");
        }
    }
}
