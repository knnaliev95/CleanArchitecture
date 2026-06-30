using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CavabQrupu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapSirasi = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CavabQrupu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cihaz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaudRate = table.Column<int>(type: "int", nullable: true),
                    DataBit = table.Column<int>(type: "int", nullable: true),
                    StopBit = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihaz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diaqnoz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciqlama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaqnoz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EndirimTipi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EndirimTipi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuracietSebebi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuracietSebebi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdenenFaizler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdenenFaizler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OdenenFaizler_Hekim_HekimId",
                        column: x => x.HekimId,
                        principalTable: "Hekim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OlcuVahidi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlcuVahidi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pasient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Protokol = table.Column<int>(type: "int", nullable: false),
                    SenedNovu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenedNomresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarixi = table.Column<DateOnly>(type: "date", nullable: true),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeskilatId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pasient_Teskilat_TeskilatId",
                        column: x => x.TeskilatId,
                        principalTable: "Teskilat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Sinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarukcu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarukcu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telebname",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    Tesdiq = table.Column<bool>(type: "bit", nullable: false),
                    Legv = table.Column<bool>(type: "bit", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telebname", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telebname_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TOlcuVahidi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOlcuVahidi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSinif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTedarukcu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTedarukcu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTelebname",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    Tesdiq = table.Column<bool>(type: "bit", nullable: false),
                    Legv = table.Column<bool>(type: "bit", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TTelebname", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TTelebname_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Tube",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<int>(type: "int", nullable: true),
                    Reng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarkodSayi = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tube", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XidmetNovu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XidmetNovu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XidmetQrupu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XidmetQrupu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserScope",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ScopeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScopeId = table.Column<int>(type: "int", nullable: false),
                    ScopeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScope", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserScope_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Reagent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    LotNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BitmeTarixi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reagent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reagent_Cihaz_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihaz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AmbulatorMuraciet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: false),
                    TeskilatId = table.Column<int>(type: "int", nullable: false),
                    MuracietSebebiId = table.Column<int>(type: "int", nullable: false),
                    GonderenId = table.Column<int>(type: "int", nullable: true),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmbulatorMuraciet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_Hekim_GonderenId",
                        column: x => x.GonderenId,
                        principalTable: "Hekim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_Hekim_HekimId",
                        column: x => x.HekimId,
                        principalTable: "Hekim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_MuracietSebebi_MuracietSebebiId",
                        column: x => x.MuracietSebebiId,
                        principalTable: "MuracietSebebi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorMuraciet_Teskilat_TeskilatId",
                        column: x => x.TeskilatId,
                        principalTable: "Teskilat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Kassa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: false),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    OdenisNovu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OdenisTarixi = table.Column<DateOnly>(type: "date", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kassa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kassa_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PasientLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: false),
                    Qeyd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasientLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PasientLog_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    OlcuVahidiId = table.Column<int>(type: "int", nullable: false),
                    CixisVahidiId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    QutuMiqdari = table.Column<double>(type: "float", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    Edv = table.Column<double>(type: "float", nullable: true),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    CixisQiymeti = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_OlcuVahidi_CixisVahidiId",
                        column: x => x.CixisVahidiId,
                        principalTable: "OlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stock_OlcuVahidi_OlcuVahidiId",
                        column: x => x.OlcuVahidiId,
                        principalTable: "OlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Stock_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Qaime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    TedarukcuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qaime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qaime_Tedarukcu_TedarukcuId",
                        column: x => x.TedarukcuId,
                        principalTable: "Tedarukcu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    OlcuVahidiId = table.Column<int>(type: "int", nullable: false),
                    CixisVahidiId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    QutuMiqdari = table.Column<double>(type: "float", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    Edv = table.Column<double>(type: "float", nullable: true),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    CixisQiymeti = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TStock_TOlcuVahidi_CixisVahidiId",
                        column: x => x.CixisVahidiId,
                        principalTable: "TOlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TStock_TOlcuVahidi_OlcuVahidiId",
                        column: x => x.OlcuVahidiId,
                        principalTable: "TOlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TStock_TSinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "TSinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TQaime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nomre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    TedarukcuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TQaime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TQaime_TTedarukcu_TedarukcuId",
                        column: x => x.TedarukcuId,
                        principalTable: "TTedarukcu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Numune",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: false),
                    XidmetQrupuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numune", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Numune_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Numune_XidmetQrupu_XidmetQrupuId",
                        column: x => x.XidmetQrupuId,
                        principalTable: "XidmetQrupu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Sablon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    XidmetQrupuId = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sablon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sablon_Hekim_HekimId",
                        column: x => x.HekimId,
                        principalTable: "Hekim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Sablon_XidmetQrupu_XidmetQrupuId",
                        column: x => x.XidmetQrupuId,
                        principalTable: "XidmetQrupu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Xidmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    ITSQiymeti = table.Column<double>(type: "float", nullable: true),
                    XidmetNovuId = table.Column<int>(type: "int", nullable: false),
                    XidmetQrupuId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xidmet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xidmet_XidmetNovu_XidmetNovuId",
                        column: x => x.XidmetNovuId,
                        principalTable: "XidmetNovu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Xidmet_XidmetQrupu_XidmetQrupuId",
                        column: x => x.XidmetQrupuId,
                        principalTable: "XidmetQrupu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SobeMedaxil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobeMedaxil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SobeMedaxil_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SobeMedaxil_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SobeMexaric",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: true),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobeMexaric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SobeMexaric_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SobeMexaric_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SobeStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SobeStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SobeStock_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SobeStock_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TelebnameDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelebnameId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    TelebMiqdari = table.Column<double>(type: "float", nullable: false),
                    BuraxilanMiqdar = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelebnameDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelebnameDetail_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TelebnameDetail_Telebname_TelebnameId",
                        column: x => x.TelebnameId,
                        principalTable: "Telebname",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Medaxil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QaimeId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    OlcuVahidiId = table.Column<int>(type: "int", nullable: false),
                    CixisVahidiId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    QutuMiqdari = table.Column<double>(type: "float", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    Edv = table.Column<double>(type: "float", nullable: true),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    CixisQiymeti = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medaxil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medaxil_OlcuVahidi_CixisVahidiId",
                        column: x => x.CixisVahidiId,
                        principalTable: "OlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medaxil_OlcuVahidi_OlcuVahidiId",
                        column: x => x.OlcuVahidiId,
                        principalTable: "OlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medaxil_Qaime_QaimeId",
                        column: x => x.QaimeId,
                        principalTable: "Qaime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Medaxil_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TSobeMedaxil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSobeMedaxil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSobeMedaxil_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TSobeMedaxil_TStock_StockId",
                        column: x => x.StockId,
                        principalTable: "TStock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TSobeMexaric",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasientId = table.Column<int>(type: "int", nullable: true),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSobeMexaric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSobeMexaric_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TSobeMexaric_TStock_StockId",
                        column: x => x.StockId,
                        principalTable: "TStock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TSobeStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobeId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSobeStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSobeStock_Sobe_SobeId",
                        column: x => x.SobeId,
                        principalTable: "Sobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TSobeStock_TStock_StockId",
                        column: x => x.StockId,
                        principalTable: "TStock",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TMedaxil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QaimeId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    OlcuVahidiId = table.Column<int>(type: "int", nullable: false),
                    CixisVahidiId = table.Column<int>(type: "int", nullable: false),
                    Miqdar = table.Column<double>(type: "float", nullable: false),
                    QutuMiqdari = table.Column<double>(type: "float", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    Edv = table.Column<double>(type: "float", nullable: true),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    CixisQiymeti = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMedaxil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TMedaxil_TOlcuVahidi_CixisVahidiId",
                        column: x => x.CixisVahidiId,
                        principalTable: "TOlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TMedaxil_TOlcuVahidi_OlcuVahidiId",
                        column: x => x.OlcuVahidiId,
                        principalTable: "TOlcuVahidi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TMedaxil_TQaime_QaimeId",
                        column: x => x.QaimeId,
                        principalTable: "TQaime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TMedaxil_TSinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "TSinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AmbulatorXidmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MuracietId = table.Column<int>(type: "int", nullable: false),
                    XidmetId = table.Column<int>(type: "int", nullable: false),
                    HekimId = table.Column<int>(type: "int", nullable: false),
                    Qiymet = table.Column<double>(type: "float", nullable: false),
                    Mebleg = table.Column<double>(type: "float", nullable: false),
                    EndirimTipiId = table.Column<int>(type: "int", nullable: true),
                    EndirimMeblegi = table.Column<double>(type: "float", nullable: true),
                    EndirimFaizi = table.Column<double>(type: "float", nullable: true),
                    Barkod = table.Column<bool>(type: "bit", nullable: false),
                    Netice = table.Column<bool>(type: "bit", nullable: false),
                    Tarix = table.Column<DateOnly>(type: "date", nullable: false),
                    Saat = table.Column<TimeOnly>(type: "time", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: true),
                    AnestezioloqId = table.Column<int>(type: "int", nullable: true),
                    AnesteziyaNovu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmbulatorXidmet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_AmbulatorMuraciet_MuracietId",
                        column: x => x.MuracietId,
                        principalTable: "AmbulatorMuraciet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_AppUser_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_EndirimTipi_EndirimTipiId",
                        column: x => x.EndirimTipiId,
                        principalTable: "EndirimTipi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_Hekim_AnestezioloqId",
                        column: x => x.AnestezioloqId,
                        principalTable: "Hekim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_Hekim_HekimId",
                        column: x => x.HekimId,
                        principalTable: "Hekim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AmbulatorXidmet_Xidmet_XidmetId",
                        column: x => x.XidmetId,
                        principalTable: "Xidmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Faiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HekimId = table.Column<int>(type: "int", nullable: true),
                    TeskilatId = table.Column<int>(type: "int", nullable: true),
                    XidmetQrupuId = table.Column<int>(type: "int", nullable: true),
                    XidmetId = table.Column<int>(type: "int", nullable: true),
                    Mebleg = table.Column<double>(type: "float", nullable: true),
                    Faizi = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faiz_Hekim_HekimId",
                        column: x => x.HekimId,
                        principalTable: "Hekim",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faiz_Teskilat_TeskilatId",
                        column: x => x.TeskilatId,
                        principalTable: "Teskilat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faiz_XidmetQrupu_XidmetQrupuId",
                        column: x => x.XidmetQrupuId,
                        principalTable: "XidmetQrupu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faiz_Xidmet_XidmetId",
                        column: x => x.XidmetId,
                        principalTable: "Xidmet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Parametr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XidmetId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlcuVahidi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeticeTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ondalik = table.Column<int>(type: "int", nullable: false),
                    IsHesablanan = table.Column<bool>(type: "bit", nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapSirasi = table.Column<int>(type: "int", nullable: true),
                    CavabQrupuId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parametr_CavabQrupu_CavabQrupuId",
                        column: x => x.CavabQrupuId,
                        principalTable: "CavabQrupu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Parametr_Xidmet_XidmetId",
                        column: x => x.XidmetId,
                        principalTable: "Xidmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NumuneDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumuneId = table.Column<int>(type: "int", nullable: false),
                    AXidmetId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumuneDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumuneDetail_AmbulatorXidmet_AXidmetId",
                        column: x => x.AXidmetId,
                        principalTable: "AmbulatorXidmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_NumuneDetail_Numune_NumuneId",
                        column: x => x.NumuneId,
                        principalTable: "Numune",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RadiolojiNetice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    XidmetId = table.Column<int>(type: "int", nullable: false),
                    Netice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tesdiq = table.Column<bool>(type: "bit", nullable: false),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadiolojiNetice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RadiolojiNetice_AmbulatorXidmet_XidmetId",
                        column: x => x.XidmetId,
                        principalTable: "AmbulatorXidmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LisNetice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumuneId = table.Column<int>(type: "int", nullable: false),
                    PasientId = table.Column<int>(type: "int", nullable: false),
                    ParametrId = table.Column<int>(type: "int", nullable: false),
                    Netice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElaveEdilmeTarixi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TesdiqlenmeTarixi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LisNetice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LisNetice_Parametr_ParametrId",
                        column: x => x.ParametrId,
                        principalTable: "Parametr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_LisNetice_Pasient_PasientId",
                        column: x => x.PasientId,
                        principalTable: "Pasient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Referans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazId = table.Column<int>(type: "int", nullable: true),
                    ReagentId = table.Column<int>(type: "int", nullable: true),
                    ParametrId = table.Column<int>(type: "int", nullable: false),
                    Cins = table.Column<int>(type: "int", nullable: false),
                    MinYas = table.Column<int>(type: "int", nullable: false),
                    MaxYas = table.Column<int>(type: "int", nullable: false),
                    MinQiymet = table.Column<double>(type: "float", nullable: true),
                    MaxQiymet = table.Column<double>(type: "float", nullable: true),
                    Norma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referans_Cihaz_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihaz",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Referans_Parametr_ParametrId",
                        column: x => x.ParametrId,
                        principalTable: "Parametr",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Referans_Reagent_ReagentId",
                        column: x => x.ReagentId,
                        principalTable: "Reagent",
                        principalColumn: "Id");
                });

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
                name: "IX_AmbulatorMuraciet_PasientId",
                table: "AmbulatorMuraciet",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_TeskilatId",
                table: "AmbulatorMuraciet",
                column: "TeskilatId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorMuraciet_UserId",
                table: "AmbulatorMuraciet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_AnestezioloqId",
                table: "AmbulatorXidmet",
                column: "AnestezioloqId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_EndirimTipiId",
                table: "AmbulatorXidmet",
                column: "EndirimTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_HekimId",
                table: "AmbulatorXidmet",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_MuracietId",
                table: "AmbulatorXidmet",
                column: "MuracietId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_UserId",
                table: "AmbulatorXidmet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbulatorXidmet_XidmetId",
                table: "AmbulatorXidmet",
                column: "XidmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_HekimId",
                table: "Faiz",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_TeskilatId",
                table: "Faiz",
                column: "TeskilatId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_XidmetId",
                table: "Faiz",
                column: "XidmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Faiz_XidmetQrupuId",
                table: "Faiz",
                column: "XidmetQrupuId");

            migrationBuilder.CreateIndex(
                name: "IX_Kassa_PasientId",
                table: "Kassa",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_LisNetice_ParametrId",
                table: "LisNetice",
                column: "ParametrId");

            migrationBuilder.CreateIndex(
                name: "IX_LisNetice_PasientId",
                table: "LisNetice",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_CixisVahidiId",
                table: "Medaxil",
                column: "CixisVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_OlcuVahidiId",
                table: "Medaxil",
                column: "OlcuVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_QaimeId",
                table: "Medaxil",
                column: "QaimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Medaxil_SinifId",
                table: "Medaxil",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Numune_PasientId",
                table: "Numune",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_Numune_XidmetQrupuId",
                table: "Numune",
                column: "XidmetQrupuId");

            migrationBuilder.CreateIndex(
                name: "IX_NumuneDetail_AXidmetId",
                table: "NumuneDetail",
                column: "AXidmetId");

            migrationBuilder.CreateIndex(
                name: "IX_NumuneDetail_NumuneId",
                table: "NumuneDetail",
                column: "NumuneId");

            migrationBuilder.CreateIndex(
                name: "IX_OdenenFaizler_HekimId",
                table: "OdenenFaizler",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametr_CavabQrupuId",
                table: "Parametr",
                column: "CavabQrupuId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametr_XidmetId",
                table: "Parametr",
                column: "XidmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pasient_TeskilatId",
                table: "Pasient",
                column: "TeskilatId");

            migrationBuilder.CreateIndex(
                name: "IX_PasientLog_PasientId",
                table: "PasientLog",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_Qaime_TedarukcuId",
                table: "Qaime",
                column: "TedarukcuId");

            migrationBuilder.CreateIndex(
                name: "IX_RadiolojiNetice_XidmetId",
                table: "RadiolojiNetice",
                column: "XidmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Reagent_CihazId",
                table: "Reagent",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_CihazId",
                table: "Referans",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_ParametrId",
                table: "Referans",
                column: "ParametrId");

            migrationBuilder.CreateIndex(
                name: "IX_Referans_ReagentId",
                table: "Referans",
                column: "ReagentId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablon_HekimId",
                table: "Sablon",
                column: "HekimId");

            migrationBuilder.CreateIndex(
                name: "IX_Sablon_XidmetQrupuId",
                table: "Sablon",
                column: "XidmetQrupuId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMedaxil_SobeId",
                table: "SobeMedaxil",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMedaxil_StockId",
                table: "SobeMedaxil",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMexaric_PasientId",
                table: "SobeMexaric",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeMexaric_StockId",
                table: "SobeMexaric",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeStock_SobeId",
                table: "SobeStock",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_SobeStock_StockId",
                table: "SobeStock",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_CixisVahidiId",
                table: "Stock",
                column: "CixisVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_OlcuVahidiId",
                table: "Stock",
                column: "OlcuVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_SinifId",
                table: "Stock",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_Telebname_SobeId",
                table: "Telebname",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_TelebnameDetail_StockId",
                table: "TelebnameDetail",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TelebnameDetail_TelebnameId",
                table: "TelebnameDetail",
                column: "TelebnameId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_CixisVahidiId",
                table: "TMedaxil",
                column: "CixisVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_OlcuVahidiId",
                table: "TMedaxil",
                column: "OlcuVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_QaimeId",
                table: "TMedaxil",
                column: "QaimeId");

            migrationBuilder.CreateIndex(
                name: "IX_TMedaxil_SinifId",
                table: "TMedaxil",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_TQaime_TedarukcuId",
                table: "TQaime",
                column: "TedarukcuId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMedaxil_SobeId",
                table: "TSobeMedaxil",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMedaxil_StockId",
                table: "TSobeMedaxil",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMexaric_PasientId",
                table: "TSobeMexaric",
                column: "PasientId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeMexaric_StockId",
                table: "TSobeMexaric",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeStock_SobeId",
                table: "TSobeStock",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_TSobeStock_StockId",
                table: "TSobeStock",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_CixisVahidiId",
                table: "TStock",
                column: "CixisVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_OlcuVahidiId",
                table: "TStock",
                column: "OlcuVahidiId");

            migrationBuilder.CreateIndex(
                name: "IX_TStock_SinifId",
                table: "TStock",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_TTelebname_SobeId",
                table: "TTelebname",
                column: "SobeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScope_UserId",
                table: "UserScope",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Xidmet_XidmetNovuId",
                table: "Xidmet",
                column: "XidmetNovuId");

            migrationBuilder.CreateIndex(
                name: "IX_Xidmet_XidmetQrupuId",
                table: "Xidmet",
                column: "XidmetQrupuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diaqnoz");

            migrationBuilder.DropTable(
                name: "Faiz");

            migrationBuilder.DropTable(
                name: "Kassa");

            migrationBuilder.DropTable(
                name: "LisNetice");

            migrationBuilder.DropTable(
                name: "Medaxil");

            migrationBuilder.DropTable(
                name: "NumuneDetail");

            migrationBuilder.DropTable(
                name: "OdenenFaizler");

            migrationBuilder.DropTable(
                name: "PasientLog");

            migrationBuilder.DropTable(
                name: "RadiolojiNetice");

            migrationBuilder.DropTable(
                name: "Referans");

            migrationBuilder.DropTable(
                name: "Sablon");

            migrationBuilder.DropTable(
                name: "SobeMedaxil");

            migrationBuilder.DropTable(
                name: "SobeMexaric");

            migrationBuilder.DropTable(
                name: "SobeStock");

            migrationBuilder.DropTable(
                name: "TelebnameDetail");

            migrationBuilder.DropTable(
                name: "TMedaxil");

            migrationBuilder.DropTable(
                name: "TSobeMedaxil");

            migrationBuilder.DropTable(
                name: "TSobeMexaric");

            migrationBuilder.DropTable(
                name: "TSobeStock");

            migrationBuilder.DropTable(
                name: "TTelebname");

            migrationBuilder.DropTable(
                name: "Tube");

            migrationBuilder.DropTable(
                name: "UserScope");

            migrationBuilder.DropTable(
                name: "Qaime");

            migrationBuilder.DropTable(
                name: "Numune");

            migrationBuilder.DropTable(
                name: "AmbulatorXidmet");

            migrationBuilder.DropTable(
                name: "Parametr");

            migrationBuilder.DropTable(
                name: "Reagent");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Telebname");

            migrationBuilder.DropTable(
                name: "TQaime");

            migrationBuilder.DropTable(
                name: "TStock");

            migrationBuilder.DropTable(
                name: "Tedarukcu");

            migrationBuilder.DropTable(
                name: "AmbulatorMuraciet");

            migrationBuilder.DropTable(
                name: "EndirimTipi");

            migrationBuilder.DropTable(
                name: "CavabQrupu");

            migrationBuilder.DropTable(
                name: "Xidmet");

            migrationBuilder.DropTable(
                name: "Cihaz");

            migrationBuilder.DropTable(
                name: "OlcuVahidi");

            migrationBuilder.DropTable(
                name: "Sinif");

            migrationBuilder.DropTable(
                name: "TTedarukcu");

            migrationBuilder.DropTable(
                name: "TOlcuVahidi");

            migrationBuilder.DropTable(
                name: "TSinif");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "MuracietSebebi");

            migrationBuilder.DropTable(
                name: "Pasient");

            migrationBuilder.DropTable(
                name: "XidmetNovu");

            migrationBuilder.DropTable(
                name: "XidmetQrupu");
        }
    }
}
