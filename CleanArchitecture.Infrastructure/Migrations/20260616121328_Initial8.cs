using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Xidmet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "UserScope",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Tube",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TTelebname",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSinif",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TQaime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Teskilat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Telebname",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Stock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeStock",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sobe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sinif",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sablon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Referans",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Reagent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Qaime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "PasientLog",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Pasient",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Parametr",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Numune",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Medaxil",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "LisNetice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Kassa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Ixtisas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Hekim",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Faiz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Cihaz",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune");

            migrationBuilder.DropForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans");

            migrationBuilder.DropForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock");

            migrationBuilder.DropForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock");

            migrationBuilder.DropForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "XidmetQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "XidmetNovu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Xidmet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "UserScope",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Tube",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TTelebname",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TTedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TSinif",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TQaime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TOlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Teskilat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "TelebnameDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Telebname",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Tedarukcu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Stock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeStock",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeMexaric",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "SobeMedaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sobe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sinif",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Sablon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Referans",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Reagent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "RadiolojiNetice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Qaime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "PasientLog",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Pasient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Parametr",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "OlcuVahidi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "OdenenFaizler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "NumuneDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Numune",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "MuracietSebebi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Medaxil",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "LisNetice",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Kassa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Ixtisas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Hekim",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Faiz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "EndirimTipi",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Diaqnoz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "Cihaz",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "CavabQrupu",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorXidmet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeleteUserId",
                table: "AmbulatorMuraciet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_DeleteUserId",
                table: "AmbulatorMuraciet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_DeleteUserId",
                table: "CavabQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_DeleteUserId",
                table: "Cihaz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_DeleteUserId",
                table: "Diaqnoz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_DeleteUserId",
                table: "EndirimTipi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_DeleteUserId",
                table: "Faiz",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_DeleteUserId",
                table: "Hekim",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_DeleteUserId",
                table: "Ixtisas",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_DeleteUserId",
                table: "Kassa",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_DeleteUserId",
                table: "LisNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_DeleteUserId",
                table: "Medaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_DeleteUserId",
                table: "MuracietSebebi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_DeleteUserId",
                table: "Numune",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_DeleteUserId",
                table: "NumuneDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_DeleteUserId",
                table: "OdenenFaizler",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_DeleteUserId",
                table: "OlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_DeleteUserId",
                table: "Parametr",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_DeleteUserId",
                table: "Pasient",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_DeleteUserId",
                table: "PasientLog",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_DeleteUserId",
                table: "Qaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_DeleteUserId",
                table: "RadiolojiNetice",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_DeleteUserId",
                table: "Reagent",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_DeleteUserId",
                table: "Referans",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_DeleteUserId",
                table: "Sablon",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_DeleteUserId",
                table: "Sinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_DeleteUserId",
                table: "Sobe",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_DeleteUserId",
                table: "SobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_DeleteUserId",
                table: "SobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_DeleteUserId",
                table: "SobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_DeleteUserId",
                table: "Stock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_DeleteUserId",
                table: "Tedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_DeleteUserId",
                table: "Telebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_DeleteUserId",
                table: "TelebnameDetail",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_DeleteUserId",
                table: "Teskilat",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_DeleteUserId",
                table: "TMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_DeleteUserId",
                table: "TOlcuVahidi",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_DeleteUserId",
                table: "TQaime",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_DeleteUserId",
                table: "TSinif",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_DeleteUserId",
                table: "TSobeMedaxil",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_DeleteUserId",
                table: "TSobeMexaric",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_DeleteUserId",
                table: "TSobeStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_DeleteUserId",
                table: "TStock",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_DeleteUserId",
                table: "TTedarukcu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_DeleteUserId",
                table: "TTelebname",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_DeleteUserId",
                table: "Tube",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_DeleteUserId",
                table: "Xidmet",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_DeleteUserId",
                table: "XidmetNovu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_DeleteUserId",
                table: "XidmetQrupu",
                column: "DeleteUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
