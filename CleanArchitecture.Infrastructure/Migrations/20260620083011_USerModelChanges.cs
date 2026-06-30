using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class USerModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_CreateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_CreateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_CreateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_CreateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_CreateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_CreateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_CreateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_CreateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_CreateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_CreateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_CreateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_CreateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_CreateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_CreateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_CreateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_CreateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_CreateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_CreateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_CreateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_CreateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_CreateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_CreateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_CreateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_CreateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_CreateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_CreateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_CreateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_CreateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_CreateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_CreateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_CreateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_CreateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_CreateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_CreateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_CreateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_CreateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_CreateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_CreateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_CreateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_CreateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_CreateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_CreateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_CreateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_CreateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_CreateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_CreateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreateUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleteUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UpdateUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_CreateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_CreateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_CreateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_CreateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu");

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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UpdateUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_UpdateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeleteUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreateUserId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_CreateUserId");

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
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                name: "FK_AmbulatorMuraciet_AspNetUsers_CreateUserId",
                table: "AmbulatorMuraciet",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_DeleteUserId",
                table: "AmbulatorMuraciet",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_CreateUserId",
                table: "AmbulatorXidmet",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_DeleteUserId",
                table: "AmbulatorXidmet",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_CreateUserId",
                table: "AspNetUsers",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DeleteUserId",
                table: "AspNetUsers",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UpdateUserId",
                table: "AspNetUsers",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_CreateUserId",
                table: "CavabQrupu",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_DeleteUserId",
                table: "CavabQrupu",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_AspNetUsers_CreateUserId",
                table: "Cihaz",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_AspNetUsers_DeleteUserId",
                table: "Cihaz",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_AspNetUsers_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_CreateUserId",
                table: "Diaqnoz",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_DeleteUserId",
                table: "Diaqnoz",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_CreateUserId",
                table: "EndirimTipi",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_DeleteUserId",
                table: "EndirimTipi",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_AspNetUsers_CreateUserId",
                table: "Faiz",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_AspNetUsers_DeleteUserId",
                table: "Faiz",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_AspNetUsers_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_AspNetUsers_CreateUserId",
                table: "Hekim",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_AspNetUsers_DeleteUserId",
                table: "Hekim",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_AspNetUsers_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_AspNetUsers_CreateUserId",
                table: "Ixtisas",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_AspNetUsers_DeleteUserId",
                table: "Ixtisas",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_AspNetUsers_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_AspNetUsers_CreateUserId",
                table: "Kassa",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_AspNetUsers_DeleteUserId",
                table: "Kassa",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_AspNetUsers_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_AspNetUsers_CreateUserId",
                table: "LisNetice",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_AspNetUsers_DeleteUserId",
                table: "LisNetice",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_AspNetUsers_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_AspNetUsers_CreateUserId",
                table: "Medaxil",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_AspNetUsers_DeleteUserId",
                table: "Medaxil",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_AspNetUsers_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_CreateUserId",
                table: "MuracietSebebi",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_DeleteUserId",
                table: "MuracietSebebi",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_AspNetUsers_CreateUserId",
                table: "Numune",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_AspNetUsers_DeleteUserId",
                table: "Numune",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_AspNetUsers_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_CreateUserId",
                table: "NumuneDetail",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_DeleteUserId",
                table: "NumuneDetail",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_CreateUserId",
                table: "OdenenFaizler",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_DeleteUserId",
                table: "OdenenFaizler",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_CreateUserId",
                table: "OlcuVahidi",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_DeleteUserId",
                table: "OlcuVahidi",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_AspNetUsers_CreateUserId",
                table: "Parametr",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_AspNetUsers_DeleteUserId",
                table: "Parametr",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_AspNetUsers_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_AspNetUsers_CreateUserId",
                table: "Pasient",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_AspNetUsers_DeleteUserId",
                table: "Pasient",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_AspNetUsers_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_AspNetUsers_CreateUserId",
                table: "PasientLog",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_AspNetUsers_DeleteUserId",
                table: "PasientLog",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_AspNetUsers_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_AspNetUsers_CreateUserId",
                table: "Qaime",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_AspNetUsers_DeleteUserId",
                table: "Qaime",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_AspNetUsers_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_CreateUserId",
                table: "RadiolojiNetice",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_DeleteUserId",
                table: "RadiolojiNetice",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_AspNetUsers_CreateUserId",
                table: "Reagent",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_AspNetUsers_DeleteUserId",
                table: "Reagent",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_AspNetUsers_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_AspNetUsers_CreateUserId",
                table: "Referans",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_AspNetUsers_DeleteUserId",
                table: "Referans",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_AspNetUsers_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_AspNetUsers_CreateUserId",
                table: "Sablon",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_AspNetUsers_DeleteUserId",
                table: "Sablon",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_AspNetUsers_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_AspNetUsers_CreateUserId",
                table: "Sinif",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_AspNetUsers_DeleteUserId",
                table: "Sinif",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_AspNetUsers_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_AspNetUsers_CreateUserId",
                table: "Sobe",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_AspNetUsers_DeleteUserId",
                table: "Sobe",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_AspNetUsers_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_CreateUserId",
                table: "SobeMedaxil",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_DeleteUserId",
                table: "SobeMedaxil",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_CreateUserId",
                table: "SobeMexaric",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_DeleteUserId",
                table: "SobeMexaric",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_AspNetUsers_CreateUserId",
                table: "SobeStock",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_AspNetUsers_DeleteUserId",
                table: "SobeStock",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_AspNetUsers_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_AspNetUsers_CreateUserId",
                table: "Stock",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_AspNetUsers_DeleteUserId",
                table: "Stock",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_AspNetUsers_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_CreateUserId",
                table: "Tedarukcu",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_DeleteUserId",
                table: "Tedarukcu",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_AspNetUsers_CreateUserId",
                table: "Telebname",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_AspNetUsers_DeleteUserId",
                table: "Telebname",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_AspNetUsers_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_CreateUserId",
                table: "TelebnameDetail",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_DeleteUserId",
                table: "TelebnameDetail",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_AspNetUsers_CreateUserId",
                table: "Teskilat",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_AspNetUsers_DeleteUserId",
                table: "Teskilat",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_AspNetUsers_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_AspNetUsers_CreateUserId",
                table: "TMedaxil",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_AspNetUsers_DeleteUserId",
                table: "TMedaxil",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_AspNetUsers_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_CreateUserId",
                table: "TOlcuVahidi",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_DeleteUserId",
                table: "TOlcuVahidi",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_AspNetUsers_CreateUserId",
                table: "TQaime",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_AspNetUsers_DeleteUserId",
                table: "TQaime",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_AspNetUsers_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_AspNetUsers_CreateUserId",
                table: "TSinif",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_AspNetUsers_DeleteUserId",
                table: "TSinif",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_AspNetUsers_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_CreateUserId",
                table: "TSobeMedaxil",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_DeleteUserId",
                table: "TSobeMedaxil",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_CreateUserId",
                table: "TSobeMexaric",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_DeleteUserId",
                table: "TSobeMexaric",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_AspNetUsers_CreateUserId",
                table: "TSobeStock",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_AspNetUsers_DeleteUserId",
                table: "TSobeStock",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_AspNetUsers_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_AspNetUsers_CreateUserId",
                table: "TStock",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_AspNetUsers_DeleteUserId",
                table: "TStock",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_AspNetUsers_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_CreateUserId",
                table: "TTedarukcu",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_DeleteUserId",
                table: "TTedarukcu",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_AspNetUsers_CreateUserId",
                table: "TTelebname",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_AspNetUsers_DeleteUserId",
                table: "TTelebname",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_AspNetUsers_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_AspNetUsers_CreateUserId",
                table: "Tube",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_AspNetUsers_DeleteUserId",
                table: "Tube",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_AspNetUsers_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_AspNetUsers_CreateUserId",
                table: "UserScope",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_AspNetUsers_DeleteUserId",
                table: "UserScope",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_AspNetUsers_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_AspNetUsers_UserId",
                table: "UserScope",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_AspNetUsers_CreateUserId",
                table: "Xidmet",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_AspNetUsers_DeleteUserId",
                table: "Xidmet",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_AspNetUsers_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_CreateUserId",
                table: "XidmetNovu",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_DeleteUserId",
                table: "XidmetNovu",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_CreateUserId",
                table: "XidmetQrupu",
                column: "CreateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_DeleteUserId",
                table: "XidmetQrupu",
                column: "DeleteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_CreateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UpdateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_AspNetUsers_UserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_CreateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_AspNetUsers_UserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_CreateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_DeleteUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UpdateUserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_CreateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_AspNetUsers_UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_AspNetUsers_CreateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_AspNetUsers_DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_AspNetUsers_UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_CreateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_AspNetUsers_UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_CreateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_AspNetUsers_UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_AspNetUsers_CreateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_AspNetUsers_DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_AspNetUsers_UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_AspNetUsers_CreateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_AspNetUsers_DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_AspNetUsers_UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_AspNetUsers_CreateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_AspNetUsers_DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_AspNetUsers_UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_AspNetUsers_CreateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_AspNetUsers_DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_AspNetUsers_UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_AspNetUsers_CreateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_AspNetUsers_DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_AspNetUsers_UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_AspNetUsers_CreateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_AspNetUsers_DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_AspNetUsers_UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_CreateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_AspNetUsers_UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_AspNetUsers_CreateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_AspNetUsers_DeleteUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_AspNetUsers_UpdateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_CreateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_AspNetUsers_UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_CreateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_AspNetUsers_UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_CreateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_AspNetUsers_UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_AspNetUsers_CreateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_AspNetUsers_DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_AspNetUsers_UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_AspNetUsers_CreateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_AspNetUsers_DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_AspNetUsers_UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_AspNetUsers_CreateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_AspNetUsers_DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_AspNetUsers_UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_AspNetUsers_CreateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_AspNetUsers_DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_AspNetUsers_UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_CreateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_AspNetUsers_UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_AspNetUsers_CreateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_AspNetUsers_DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_AspNetUsers_UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_AspNetUsers_CreateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_AspNetUsers_DeleteUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_AspNetUsers_UpdateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_AspNetUsers_CreateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_AspNetUsers_DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_AspNetUsers_UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_AspNetUsers_CreateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_AspNetUsers_DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_AspNetUsers_UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_AspNetUsers_CreateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_AspNetUsers_DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_AspNetUsers_UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_CreateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_AspNetUsers_UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_CreateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_AspNetUsers_UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_AspNetUsers_CreateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_AspNetUsers_DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_AspNetUsers_UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_AspNetUsers_CreateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_AspNetUsers_DeleteUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_AspNetUsers_UpdateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_CreateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_AspNetUsers_UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_AspNetUsers_CreateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_AspNetUsers_DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_AspNetUsers_UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_CreateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_AspNetUsers_UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_AspNetUsers_CreateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_AspNetUsers_DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_AspNetUsers_UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_AspNetUsers_CreateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_AspNetUsers_DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_AspNetUsers_UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_CreateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_AspNetUsers_UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_AspNetUsers_CreateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_AspNetUsers_DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_AspNetUsers_UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_AspNetUsers_CreateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_AspNetUsers_DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_AspNetUsers_UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_CreateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_AspNetUsers_UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_CreateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_AspNetUsers_UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_AspNetUsers_CreateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_AspNetUsers_DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_AspNetUsers_UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_AspNetUsers_CreateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_AspNetUsers_DeleteUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_AspNetUsers_UpdateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_CreateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_AspNetUsers_UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_AspNetUsers_CreateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_AspNetUsers_DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_AspNetUsers_UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_AspNetUsers_CreateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_AspNetUsers_DeleteUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_AspNetUsers_UpdateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_AspNetUsers_CreateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_AspNetUsers_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_AspNetUsers_UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_AspNetUsers_UserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_AspNetUsers_CreateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_AspNetUsers_DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_AspNetUsers_UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_CreateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_AspNetUsers_UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_CreateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_AspNetUsers_UpdateUserId",
                table: "XidmetQrupu");

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

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_UpdateUserId",
                table: "Users",
                newName: "IX_Users_UpdateUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_DeleteUserId",
                table: "Users",
                newName: "IX_Users_DeleteUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_CreateUserId",
                table: "Users",
                newName: "IX_Users_CreateUserId");

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
                    AttestationObject = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ClientDataJson = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsBackedUp = table.Column<bool>(type: "bit", nullable: false),
                    IsBackupEligible = table.Column<bool>(type: "bit", nullable: false),
                    IsUserVerified = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SignCount = table.Column<long>(type: "bigint", nullable: false),
                    Transports = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "FK_AmbulatorMuraciet_Users_CreateUserId",
                table: "AmbulatorMuraciet",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_CreateUserId",
                table: "AmbulatorXidmet",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UserId",
                table: "AmbulatorXidmet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_CreateUserId",
                table: "CavabQrupu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_CreateUserId",
                table: "Cihaz",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_CreateUserId",
                table: "Diaqnoz",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_CreateUserId",
                table: "EndirimTipi",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_CreateUserId",
                table: "Faiz",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_CreateUserId",
                table: "Hekim",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_CreateUserId",
                table: "Ixtisas",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_CreateUserId",
                table: "Kassa",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_CreateUserId",
                table: "LisNetice",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_CreateUserId",
                table: "Medaxil",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_CreateUserId",
                table: "MuracietSebebi",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_CreateUserId",
                table: "Numune",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_CreateUserId",
                table: "NumuneDetail",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_CreateUserId",
                table: "OdenenFaizler",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_CreateUserId",
                table: "OlcuVahidi",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_CreateUserId",
                table: "Parametr",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_CreateUserId",
                table: "Pasient",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_CreateUserId",
                table: "PasientLog",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_CreateUserId",
                table: "Qaime",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_CreateUserId",
                table: "RadiolojiNetice",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_CreateUserId",
                table: "Reagent",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_CreateUserId",
                table: "Referans",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_CreateUserId",
                table: "Sablon",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_CreateUserId",
                table: "Sinif",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_CreateUserId",
                table: "Sobe",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_CreateUserId",
                table: "SobeMedaxil",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_CreateUserId",
                table: "SobeMexaric",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_CreateUserId",
                table: "SobeStock",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_CreateUserId",
                table: "Stock",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_CreateUserId",
                table: "Tedarukcu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_CreateUserId",
                table: "Telebname",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_CreateUserId",
                table: "TelebnameDetail",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_CreateUserId",
                table: "Teskilat",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_CreateUserId",
                table: "TMedaxil",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_CreateUserId",
                table: "TOlcuVahidi",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_CreateUserId",
                table: "TQaime",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_CreateUserId",
                table: "TSinif",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_CreateUserId",
                table: "TSobeMedaxil",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_CreateUserId",
                table: "TSobeMexaric",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_CreateUserId",
                table: "TSobeStock",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_CreateUserId",
                table: "TStock",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_CreateUserId",
                table: "TTedarukcu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_CreateUserId",
                table: "TTelebname",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_CreateUserId",
                table: "Tube",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_CreateUserId",
                table: "UserScope",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UserId",
                table: "UserScope",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_CreateUserId",
                table: "Xidmet",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_CreateUserId",
                table: "XidmetNovu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_CreateUserId",
                table: "XidmetQrupu",
                column: "CreateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
