using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_AspNetUsers_UserId",
                table: "UserScope");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Xidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Xidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Xidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "UserScope",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "UserScope",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "UserScope",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Tube",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Tube",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Tube",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TTelebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TTelebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TTelebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TSobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TSobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TSobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TSinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TSinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TSinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TQaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TQaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TQaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Teskilat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Teskilat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Teskilat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Telebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Telebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Telebname",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "SobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "SobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "SobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Sobe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Sobe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Sobe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Sinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Sinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Sinif",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Sablon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Sablon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Sablon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Referans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Referans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Referans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Reagent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Reagent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Reagent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Qaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Qaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Qaime",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "PasientLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "PasientLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "PasientLog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Pasient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Pasient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Pasient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Parametr",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Parametr",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Parametr",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Numune",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Numune",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Numune",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Medaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Medaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Medaxil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "LisNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "LisNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "LisNetice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Kassa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Kassa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Kassa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Ixtisas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Ixtisas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Ixtisas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Hekim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Hekim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Hekim",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Faiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Faiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Faiz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "Cihaz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "Cihaz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "Cihaz",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IdentityPasskeyData",
                columns: table => new
                {
                    PublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SignCount = table.Column<long>(type: "bigint", nullable: false),
                    Transports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUserVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsBackupEligible = table.Column<bool>(type: "bit", nullable: false),
                    IsBackedUp = table.Column<bool>(type: "bit", nullable: false),
                    AttestationObject = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ClientDataJson = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UserId",
                table: "AmbulatorXidmet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UserId",
                table: "UserScope",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UserId",
                table: "UserScope");

            migrationBuilder.DropTable(
                name: "IdentityPasskeyData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Xidmet");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "UserScope");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Tube");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Tube");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Tube");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TTelebname");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TStock");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TStock");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TStock");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TSobeStock");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TSinif");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TQaime");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TMedaxil");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Teskilat");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Telebname");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "SobeStock");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Sobe");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Sablon");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Referans");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Referans");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Referans");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Reagent");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Qaime");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "PasientLog");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Pasient");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Parametr");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Numune");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Numune");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Numune");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Medaxil");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "LisNetice");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Kassa");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Ixtisas");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Hekim");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Faiz");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Cihaz");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_AspNetUsers_UserId",
                table: "UserScope",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
