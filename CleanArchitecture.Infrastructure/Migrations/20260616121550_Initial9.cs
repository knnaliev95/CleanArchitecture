using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Xidmet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "UserScope",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Tube",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TTelebname",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSinif",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TQaime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Teskilat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Telebname",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Stock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sobe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sinif",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sablon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Referans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Reagent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Qaime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "PasientLog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Pasient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Parametr",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Numune",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Medaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "LisNetice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Kassa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Ixtisas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Hekim",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Faiz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Cihaz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu");

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Xidmet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "UserScope",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Tube",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TTelebname",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TSinif",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TQaime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Teskilat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Telebname",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sobe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sinif",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Sablon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Referans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Reagent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Qaime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "PasientLog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Pasient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Parametr",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Numune",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Medaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "LisNetice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Kassa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Ixtisas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Hekim",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Faiz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "Cihaz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UpdateUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
