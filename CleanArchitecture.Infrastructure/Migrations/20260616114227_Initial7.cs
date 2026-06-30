using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_XidmetQrupu_CreateUserId",
                table: "XidmetQrupu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XidmetQrupu_DeleteUserId",
                table: "XidmetQrupu",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XidmetQrupu_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XidmetNovu_CreateUserId",
                table: "XidmetNovu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XidmetNovu_DeleteUserId",
                table: "XidmetNovu",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XidmetNovu_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Xidmet_CreateUserId",
                table: "Xidmet",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Xidmet_DeleteUserId",
                table: "Xidmet",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Xidmet_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScope_CreateUserId",
                table: "UserScope",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScope_DeleteUserId",
                table: "UserScope",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScope_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tube_CreateUserId",
                table: "Tube",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tube_DeleteUserId",
                table: "Tube",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tube_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTelebname_CreateUserId",
                table: "TTelebname",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTelebname_DeleteUserId",
                table: "TTelebname",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTelebname_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTedarukcu_CreateUserId",
                table: "TTedarukcu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTedarukcu_DeleteUserId",
                table: "TTedarukcu",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TTedarukcu_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_CreateUserId",
                table: "TStock",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_DeleteUserId",
                table: "TStock",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeStock_CreateUserId",
                table: "TSobeStock",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeStock_DeleteUserId",
                table: "TSobeStock",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeStock_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMexaric_CreateUserId",
                table: "TSobeMexaric",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMexaric_DeleteUserId",
                table: "TSobeMexaric",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMexaric_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMedaxil_CreateUserId",
                table: "TSobeMedaxil",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMedaxil_DeleteUserId",
                table: "TSobeMedaxil",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMedaxil_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSinif_CreateUserId",
                table: "TSinif",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSinif_DeleteUserId",
                table: "TSinif",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TSinif_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TQaime_CreateUserId",
                table: "TQaime",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TQaime_DeleteUserId",
                table: "TQaime",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TQaime_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TOlcuVahidi_CreateUserId",
                table: "TOlcuVahidi",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TOlcuVahidi_DeleteUserId",
                table: "TOlcuVahidi",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TOlcuVahidi_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_CreateUserId",
                table: "TMedaxil",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_DeleteUserId",
                table: "TMedaxil",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teskilat_CreateUserId",
                table: "Teskilat",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teskilat_DeleteUserId",
                table: "Teskilat",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teskilat_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TelebnameDetail_CreateUserId",
                table: "TelebnameDetail",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TelebnameDetail_DeleteUserId",
                table: "TelebnameDetail",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TelebnameDetail_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Telebname_CreateUserId",
                table: "Telebname",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Telebname_DeleteUserId",
                table: "Telebname",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Telebname_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarukcu_CreateUserId",
                table: "Tedarukcu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarukcu_DeleteUserId",
                table: "Tedarukcu",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarukcu_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CreateUserId",
                table: "Stock",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_DeleteUserId",
                table: "Stock",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeStock_CreateUserId",
                table: "SobeStock",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeStock_DeleteUserId",
                table: "SobeStock",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeStock_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMexaric_CreateUserId",
                table: "SobeMexaric",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMexaric_DeleteUserId",
                table: "SobeMexaric",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMexaric_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMedaxil_CreateUserId",
                table: "SobeMedaxil",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMedaxil_DeleteUserId",
                table: "SobeMedaxil",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMedaxil_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_CreateUserId",
                table: "Sobe",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_DeleteUserId",
                table: "Sobe",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sobe_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_CreateUserId",
                table: "Sinif",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_DeleteUserId",
                table: "Sinif",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablon_CreateUserId",
                table: "Sablon",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablon_DeleteUserId",
                table: "Sablon",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablon_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_CreateUserId",
                table: "Referans",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_DeleteUserId",
                table: "Referans",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reagent_CreateUserId",
                table: "Reagent",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reagent_DeleteUserId",
                table: "Reagent",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reagent_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RadiolojiNetice_CreateUserId",
                table: "RadiolojiNetice",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RadiolojiNetice_DeleteUserId",
                table: "RadiolojiNetice",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RadiolojiNetice_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qaime_CreateUserId",
                table: "Qaime",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qaime_DeleteUserId",
                table: "Qaime",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Qaime_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasientLog_CreateUserId",
                table: "PasientLog",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasientLog_DeleteUserId",
                table: "PasientLog",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PasientLog_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasient_CreateUserId",
                table: "Pasient",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasient_DeleteUserId",
                table: "Pasient",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasient_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametr_CreateUserId",
                table: "Parametr",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametr_DeleteUserId",
                table: "Parametr",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametr_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OlcuVahidi_CreateUserId",
                table: "OlcuVahidi",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OlcuVahidi_DeleteUserId",
                table: "OlcuVahidi",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OlcuVahidi_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OdenenFaizler_CreateUserId",
                table: "OdenenFaizler",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OdenenFaizler_DeleteUserId",
                table: "OdenenFaizler",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OdenenFaizler_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NumuneDetail_CreateUserId",
                table: "NumuneDetail",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NumuneDetail_DeleteUserId",
                table: "NumuneDetail",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_NumuneDetail_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Numune_CreateUserId",
                table: "Numune",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Numune_DeleteUserId",
                table: "Numune",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Numune_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MuracietSebebi_CreateUserId",
                table: "MuracietSebebi",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MuracietSebebi_DeleteUserId",
                table: "MuracietSebebi",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MuracietSebebi_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_CreateUserId",
                table: "Medaxil",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_DeleteUserId",
                table: "Medaxil",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LisNetice_CreateUserId",
                table: "LisNetice",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LisNetice_DeleteUserId",
                table: "LisNetice",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LisNetice_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Kassa_CreateUserId",
                table: "Kassa",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Kassa_DeleteUserId",
                table: "Kassa",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Kassa_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ixtisas_CreateUserId",
                table: "Ixtisas",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ixtisas_DeleteUserId",
                table: "Ixtisas",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ixtisas_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hekim_CreateUserId",
                table: "Hekim",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hekim_DeleteUserId",
                table: "Hekim",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hekim_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_CreateUserId",
                table: "Faiz",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_DeleteUserId",
                table: "Faiz",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EndirimTipi_CreateUserId",
                table: "EndirimTipi",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EndirimTipi_DeleteUserId",
                table: "EndirimTipi",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EndirimTipi_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diaqnoz_CreateUserId",
                table: "Diaqnoz",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diaqnoz_DeleteUserId",
                table: "Diaqnoz",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Diaqnoz_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cihaz_CreateUserId",
                table: "Cihaz",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cihaz_DeleteUserId",
                table: "Cihaz",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cihaz_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CavabQrupu_CreateUserId",
                table: "CavabQrupu",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CavabQrupu_DeleteUserId",
                table: "CavabQrupu",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CavabQrupu_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_CreateUserId",
                table: "AmbulatorXidmet",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_DeleteUserId",
                table: "AmbulatorXidmet",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_CreateUserId",
                table: "AmbulatorMuraciet",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_DeleteUserId",
                table: "AmbulatorMuraciet",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId");

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorMuraciet_Users_UpdateUserId",
                table: "AmbulatorMuraciet",
                column: "UpdateUserId",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
                table: "AmbulatorXidmet",
                column: "UpdateUserId",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CavabQrupu_Users_UpdateUserId",
                table: "CavabQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cihaz_Users_UpdateUserId",
                table: "Cihaz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Diaqnoz_Users_UpdateUserId",
                table: "Diaqnoz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_EndirimTipi_Users_UpdateUserId",
                table: "EndirimTipi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Faiz_Users_UpdateUserId",
                table: "Faiz",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Hekim_Users_UpdateUserId",
                table: "Hekim",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Ixtisas_Users_UpdateUserId",
                table: "Ixtisas",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Kassa_Users_UpdateUserId",
                table: "Kassa",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_LisNetice_Users_UpdateUserId",
                table: "LisNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Medaxil_Users_UpdateUserId",
                table: "Medaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MuracietSebebi_Users_UpdateUserId",
                table: "MuracietSebebi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Numune_Users_UpdateUserId",
                table: "Numune",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_NumuneDetail_Users_UpdateUserId",
                table: "NumuneDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OdenenFaizler_Users_UpdateUserId",
                table: "OdenenFaizler",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_OlcuVahidi_Users_UpdateUserId",
                table: "OlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Parametr_Users_UpdateUserId",
                table: "Parametr",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Pasient_Users_UpdateUserId",
                table: "Pasient",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_PasientLog_Users_UpdateUserId",
                table: "PasientLog",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Qaime_Users_UpdateUserId",
                table: "Qaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_RadiolojiNetice_Users_UpdateUserId",
                table: "RadiolojiNetice",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Reagent_Users_UpdateUserId",
                table: "Reagent",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Referans_Users_UpdateUserId",
                table: "Referans",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sablon_Users_UpdateUserId",
                table: "Sablon",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Users_UpdateUserId",
                table: "Sinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Sobe_Users_UpdateUserId",
                table: "Sobe",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMedaxil_Users_UpdateUserId",
                table: "SobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeMexaric_Users_UpdateUserId",
                table: "SobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SobeStock_Users_UpdateUserId",
                table: "SobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Users_UpdateUserId",
                table: "Stock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarukcu_Users_UpdateUserId",
                table: "Tedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Telebname_Users_UpdateUserId",
                table: "Telebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TelebnameDetail_Users_UpdateUserId",
                table: "TelebnameDetail",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Teskilat_Users_UpdateUserId",
                table: "Teskilat",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TMedaxil_Users_UpdateUserId",
                table: "TMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TOlcuVahidi_Users_UpdateUserId",
                table: "TOlcuVahidi",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TQaime_Users_UpdateUserId",
                table: "TQaime",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSinif_Users_UpdateUserId",
                table: "TSinif",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMedaxil_Users_UpdateUserId",
                table: "TSobeMedaxil",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeMexaric_Users_UpdateUserId",
                table: "TSobeMexaric",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TSobeStock_Users_UpdateUserId",
                table: "TSobeStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TStock_Users_UpdateUserId",
                table: "TStock",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTedarukcu_Users_UpdateUserId",
                table: "TTedarukcu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_TTelebname_Users_UpdateUserId",
                table: "TTelebname",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Tube_Users_UpdateUserId",
                table: "Tube",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
                table: "UserScope",
                column: "UpdateUserId",
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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Xidmet_Users_UpdateUserId",
                table: "Xidmet",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetNovu_Users_UpdateUserId",
                table: "XidmetNovu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_XidmetQrupu_Users_UpdateUserId",
                table: "XidmetQrupu",
                column: "UpdateUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_AmbulatorXidmet_Users_CreateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropForeignKey(
                name: "FK_AmbulatorXidmet_Users_UpdateUserId",
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
                name: "FK_UserScope_Users_CreateUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropForeignKey(
                name: "FK_UserScope_Users_UpdateUserId",
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

            migrationBuilder.DropIndex(
                name: "IX_XidmetQrupu_CreateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropIndex(
                name: "IX_XidmetQrupu_DeleteUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropIndex(
                name: "IX_XidmetQrupu_UpdateUserId",
                table: "XidmetQrupu");

            migrationBuilder.DropIndex(
                name: "IX_XidmetNovu_CreateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropIndex(
                name: "IX_XidmetNovu_DeleteUserId",
                table: "XidmetNovu");

            migrationBuilder.DropIndex(
                name: "IX_XidmetNovu_UpdateUserId",
                table: "XidmetNovu");

            migrationBuilder.DropIndex(
                name: "IX_Xidmet_CreateUserId",
                table: "Xidmet");

            migrationBuilder.DropIndex(
                name: "IX_Xidmet_DeleteUserId",
                table: "Xidmet");

            migrationBuilder.DropIndex(
                name: "IX_Xidmet_UpdateUserId",
                table: "Xidmet");

            migrationBuilder.DropIndex(
                name: "IX_UserScope_CreateUserId",
                table: "UserScope");

            migrationBuilder.DropIndex(
                name: "IX_UserScope_DeleteUserId",
                table: "UserScope");

            migrationBuilder.DropIndex(
                name: "IX_UserScope_UpdateUserId",
                table: "UserScope");

            migrationBuilder.DropIndex(
                name: "IX_Tube_CreateUserId",
                table: "Tube");

            migrationBuilder.DropIndex(
                name: "IX_Tube_DeleteUserId",
                table: "Tube");

            migrationBuilder.DropIndex(
                name: "IX_Tube_UpdateUserId",
                table: "Tube");

            migrationBuilder.DropIndex(
                name: "IX_TTelebname_CreateUserId",
                table: "TTelebname");

            migrationBuilder.DropIndex(
                name: "IX_TTelebname_DeleteUserId",
                table: "TTelebname");

            migrationBuilder.DropIndex(
                name: "IX_TTelebname_UpdateUserId",
                table: "TTelebname");

            migrationBuilder.DropIndex(
                name: "IX_TTedarukcu_CreateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_TTedarukcu_DeleteUserId",
                table: "TTedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_TTedarukcu_UpdateUserId",
                table: "TTedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_TStock_CreateUserId",
                table: "TStock");

            migrationBuilder.DropIndex(
                name: "IX_TStock_DeleteUserId",
                table: "TStock");

            migrationBuilder.DropIndex(
                name: "IX_TStock_UpdateUserId",
                table: "TStock");

            migrationBuilder.DropIndex(
                name: "IX_TSobeStock_CreateUserId",
                table: "TSobeStock");

            migrationBuilder.DropIndex(
                name: "IX_TSobeStock_DeleteUserId",
                table: "TSobeStock");

            migrationBuilder.DropIndex(
                name: "IX_TSobeStock_UpdateUserId",
                table: "TSobeStock");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMexaric_CreateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMexaric_DeleteUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMexaric_UpdateUserId",
                table: "TSobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMedaxil_CreateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMedaxil_DeleteUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_TSobeMedaxil_UpdateUserId",
                table: "TSobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_TSinif_CreateUserId",
                table: "TSinif");

            migrationBuilder.DropIndex(
                name: "IX_TSinif_DeleteUserId",
                table: "TSinif");

            migrationBuilder.DropIndex(
                name: "IX_TSinif_UpdateUserId",
                table: "TSinif");

            migrationBuilder.DropIndex(
                name: "IX_TQaime_CreateUserId",
                table: "TQaime");

            migrationBuilder.DropIndex(
                name: "IX_TQaime_DeleteUserId",
                table: "TQaime");

            migrationBuilder.DropIndex(
                name: "IX_TQaime_UpdateUserId",
                table: "TQaime");

            migrationBuilder.DropIndex(
                name: "IX_TOlcuVahidi_CreateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_TOlcuVahidi_DeleteUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_TOlcuVahidi_UpdateUserId",
                table: "TOlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_TMedaxil_CreateUserId",
                table: "TMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_TMedaxil_DeleteUserId",
                table: "TMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_TMedaxil_UpdateUserId",
                table: "TMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_Teskilat_CreateUserId",
                table: "Teskilat");

            migrationBuilder.DropIndex(
                name: "IX_Teskilat_DeleteUserId",
                table: "Teskilat");

            migrationBuilder.DropIndex(
                name: "IX_Teskilat_UpdateUserId",
                table: "Teskilat");

            migrationBuilder.DropIndex(
                name: "IX_TelebnameDetail_CreateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropIndex(
                name: "IX_TelebnameDetail_DeleteUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropIndex(
                name: "IX_TelebnameDetail_UpdateUserId",
                table: "TelebnameDetail");

            migrationBuilder.DropIndex(
                name: "IX_Telebname_CreateUserId",
                table: "Telebname");

            migrationBuilder.DropIndex(
                name: "IX_Telebname_DeleteUserId",
                table: "Telebname");

            migrationBuilder.DropIndex(
                name: "IX_Telebname_UpdateUserId",
                table: "Telebname");

            migrationBuilder.DropIndex(
                name: "IX_Tedarukcu_CreateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_Tedarukcu_DeleteUserId",
                table: "Tedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_Tedarukcu_UpdateUserId",
                table: "Tedarukcu");

            migrationBuilder.DropIndex(
                name: "IX_Stock_CreateUserId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_DeleteUserId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Stock_UpdateUserId",
                table: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_SobeStock_CreateUserId",
                table: "SobeStock");

            migrationBuilder.DropIndex(
                name: "IX_SobeStock_DeleteUserId",
                table: "SobeStock");

            migrationBuilder.DropIndex(
                name: "IX_SobeStock_UpdateUserId",
                table: "SobeStock");

            migrationBuilder.DropIndex(
                name: "IX_SobeMexaric_CreateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_SobeMexaric_DeleteUserId",
                table: "SobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_SobeMexaric_UpdateUserId",
                table: "SobeMexaric");

            migrationBuilder.DropIndex(
                name: "IX_SobeMedaxil_CreateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_SobeMedaxil_DeleteUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_SobeMedaxil_UpdateUserId",
                table: "SobeMedaxil");

            migrationBuilder.DropIndex(
                name: "IX_Sobe_CreateUserId",
                table: "Sobe");

            migrationBuilder.DropIndex(
                name: "IX_Sobe_DeleteUserId",
                table: "Sobe");

            migrationBuilder.DropIndex(
                name: "IX_Sobe_UpdateUserId",
                table: "Sobe");

            migrationBuilder.DropIndex(
                name: "IX_Sinif_CreateUserId",
                table: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_Sinif_DeleteUserId",
                table: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_Sinif_UpdateUserId",
                table: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_Sablon_CreateUserId",
                table: "Sablon");

            migrationBuilder.DropIndex(
                name: "IX_Sablon_DeleteUserId",
                table: "Sablon");

            migrationBuilder.DropIndex(
                name: "IX_Sablon_UpdateUserId",
                table: "Sablon");

            migrationBuilder.DropIndex(
                name: "IX_Referans_CreateUserId",
                table: "Referans");

            migrationBuilder.DropIndex(
                name: "IX_Referans_DeleteUserId",
                table: "Referans");

            migrationBuilder.DropIndex(
                name: "IX_Referans_UpdateUserId",
                table: "Referans");

            migrationBuilder.DropIndex(
                name: "IX_Reagent_CreateUserId",
                table: "Reagent");

            migrationBuilder.DropIndex(
                name: "IX_Reagent_DeleteUserId",
                table: "Reagent");

            migrationBuilder.DropIndex(
                name: "IX_Reagent_UpdateUserId",
                table: "Reagent");

            migrationBuilder.DropIndex(
                name: "IX_RadiolojiNetice_CreateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropIndex(
                name: "IX_RadiolojiNetice_DeleteUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropIndex(
                name: "IX_RadiolojiNetice_UpdateUserId",
                table: "RadiolojiNetice");

            migrationBuilder.DropIndex(
                name: "IX_Qaime_CreateUserId",
                table: "Qaime");

            migrationBuilder.DropIndex(
                name: "IX_Qaime_DeleteUserId",
                table: "Qaime");

            migrationBuilder.DropIndex(
                name: "IX_Qaime_UpdateUserId",
                table: "Qaime");

            migrationBuilder.DropIndex(
                name: "IX_PasientLog_CreateUserId",
                table: "PasientLog");

            migrationBuilder.DropIndex(
                name: "IX_PasientLog_DeleteUserId",
                table: "PasientLog");

            migrationBuilder.DropIndex(
                name: "IX_PasientLog_UpdateUserId",
                table: "PasientLog");

            migrationBuilder.DropIndex(
                name: "IX_Pasient_CreateUserId",
                table: "Pasient");

            migrationBuilder.DropIndex(
                name: "IX_Pasient_DeleteUserId",
                table: "Pasient");

            migrationBuilder.DropIndex(
                name: "IX_Pasient_UpdateUserId",
                table: "Pasient");

            migrationBuilder.DropIndex(
                name: "IX_Parametr_CreateUserId",
                table: "Parametr");

            migrationBuilder.DropIndex(
                name: "IX_Parametr_DeleteUserId",
                table: "Parametr");

            migrationBuilder.DropIndex(
                name: "IX_Parametr_UpdateUserId",
                table: "Parametr");

            migrationBuilder.DropIndex(
                name: "IX_OlcuVahidi_CreateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_OlcuVahidi_DeleteUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_OlcuVahidi_UpdateUserId",
                table: "OlcuVahidi");

            migrationBuilder.DropIndex(
                name: "IX_OdenenFaizler_CreateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropIndex(
                name: "IX_OdenenFaizler_DeleteUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropIndex(
                name: "IX_OdenenFaizler_UpdateUserId",
                table: "OdenenFaizler");

            migrationBuilder.DropIndex(
                name: "IX_NumuneDetail_CreateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropIndex(
                name: "IX_NumuneDetail_DeleteUserId",
                table: "NumuneDetail");

            migrationBuilder.DropIndex(
                name: "IX_NumuneDetail_UpdateUserId",
                table: "NumuneDetail");

            migrationBuilder.DropIndex(
                name: "IX_Numune_CreateUserId",
                table: "Numune");

            migrationBuilder.DropIndex(
                name: "IX_Numune_DeleteUserId",
                table: "Numune");

            migrationBuilder.DropIndex(
                name: "IX_Numune_UpdateUserId",
                table: "Numune");

            migrationBuilder.DropIndex(
                name: "IX_MuracietSebebi_CreateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropIndex(
                name: "IX_MuracietSebebi_DeleteUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropIndex(
                name: "IX_MuracietSebebi_UpdateUserId",
                table: "MuracietSebebi");

            migrationBuilder.DropIndex(
                name: "IX_Medaxil_CreateUserId",
                table: "Medaxil");

            migrationBuilder.DropIndex(
                name: "IX_Medaxil_DeleteUserId",
                table: "Medaxil");

            migrationBuilder.DropIndex(
                name: "IX_Medaxil_UpdateUserId",
                table: "Medaxil");

            migrationBuilder.DropIndex(
                name: "IX_LisNetice_CreateUserId",
                table: "LisNetice");

            migrationBuilder.DropIndex(
                name: "IX_LisNetice_DeleteUserId",
                table: "LisNetice");

            migrationBuilder.DropIndex(
                name: "IX_LisNetice_UpdateUserId",
                table: "LisNetice");

            migrationBuilder.DropIndex(
                name: "IX_Kassa_CreateUserId",
                table: "Kassa");

            migrationBuilder.DropIndex(
                name: "IX_Kassa_DeleteUserId",
                table: "Kassa");

            migrationBuilder.DropIndex(
                name: "IX_Kassa_UpdateUserId",
                table: "Kassa");

            migrationBuilder.DropIndex(
                name: "IX_Ixtisas_CreateUserId",
                table: "Ixtisas");

            migrationBuilder.DropIndex(
                name: "IX_Ixtisas_DeleteUserId",
                table: "Ixtisas");

            migrationBuilder.DropIndex(
                name: "IX_Ixtisas_UpdateUserId",
                table: "Ixtisas");

            migrationBuilder.DropIndex(
                name: "IX_Hekim_CreateUserId",
                table: "Hekim");

            migrationBuilder.DropIndex(
                name: "IX_Hekim_DeleteUserId",
                table: "Hekim");

            migrationBuilder.DropIndex(
                name: "IX_Hekim_UpdateUserId",
                table: "Hekim");

            migrationBuilder.DropIndex(
                name: "IX_Faiz_CreateUserId",
                table: "Faiz");

            migrationBuilder.DropIndex(
                name: "IX_Faiz_DeleteUserId",
                table: "Faiz");

            migrationBuilder.DropIndex(
                name: "IX_Faiz_UpdateUserId",
                table: "Faiz");

            migrationBuilder.DropIndex(
                name: "IX_EndirimTipi_CreateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropIndex(
                name: "IX_EndirimTipi_DeleteUserId",
                table: "EndirimTipi");

            migrationBuilder.DropIndex(
                name: "IX_EndirimTipi_UpdateUserId",
                table: "EndirimTipi");

            migrationBuilder.DropIndex(
                name: "IX_Diaqnoz_CreateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropIndex(
                name: "IX_Diaqnoz_DeleteUserId",
                table: "Diaqnoz");

            migrationBuilder.DropIndex(
                name: "IX_Diaqnoz_UpdateUserId",
                table: "Diaqnoz");

            migrationBuilder.DropIndex(
                name: "IX_Cihaz_CreateUserId",
                table: "Cihaz");

            migrationBuilder.DropIndex(
                name: "IX_Cihaz_DeleteUserId",
                table: "Cihaz");

            migrationBuilder.DropIndex(
                name: "IX_Cihaz_UpdateUserId",
                table: "Cihaz");

            migrationBuilder.DropIndex(
                name: "IX_CavabQrupu_CreateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropIndex(
                name: "IX_CavabQrupu_DeleteUserId",
                table: "CavabQrupu");

            migrationBuilder.DropIndex(
                name: "IX_CavabQrupu_UpdateUserId",
                table: "CavabQrupu");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorXidmet_CreateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorXidmet_DeleteUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorXidmet_UpdateUserId",
                table: "AmbulatorXidmet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_CreateUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_DeleteUserId",
                table: "AmbulatorMuraciet");

            migrationBuilder.DropIndex(
                name: "IX_AmbulatorMuraciet_UpdateUserId",
                table: "AmbulatorMuraciet");
        }
    }
}
