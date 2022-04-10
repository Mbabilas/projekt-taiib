using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class pierwsza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MozliwosciBojowe = table.Column<int>(type: "INTEGER", nullable: false),
                    SilyLadowe = table.Column<int>(type: "INTEGER", nullable: false),
                    SilyPowietrzne = table.Column<int>(type: "INTEGER", nullable: false),
                    SilyMorskie = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dywizja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MiejsceStacjonowania = table.Column<string>(type: "TEXT", nullable: true),
                    Personel = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dywizja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modele",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Przeznaczenie = table.Column<string>(type: "TEXT", nullable: true),
                    Typ = table.Column<string>(type: "TEXT", nullable: true),
                    Mnoznik = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modele", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stopnie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Oficerski = table.Column<bool>(type: "INTEGER", nullable: false),
                    Generalski = table.Column<bool>(type: "INTEGER", nullable: false),
                    Podoficerski = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stopnie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zgloszenia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Kategoria = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Plec = table.Column<bool>(type: "INTEGER", nullable: false),
                    TypZgloszenia = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TrescZgloszenia = table.Column<string>(type: "TEXT", nullable: true),
                    OrzeczenieLekarskie = table.Column<bool>(type: "INTEGER", nullable: false),
                    Zatwierdzony = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zgloszenia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zgloszenia_Armie_Id",
                        column: x => x.Id,
                        principalTable: "Armie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bronie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    WUzyciu = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bronie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bronie_Armie_Id",
                        column: x => x.Id,
                        principalTable: "Armie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bronie_Modele_Id",
                        column: x => x.Id,
                        principalTable: "Modele",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zolnierze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Imie = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    MiejsceUrodzenia = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Pesel = table.Column<int>(type: "INTEGER", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zolnierze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zolnierze_Dywizja_Id",
                        column: x => x.Id,
                        principalTable: "Dywizja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zolnierze_Stopnie_Id",
                        column: x => x.Id,
                        principalTable: "Stopnie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bronie");

            migrationBuilder.DropTable(
                name: "Zgloszenia");

            migrationBuilder.DropTable(
                name: "Zolnierze");

            migrationBuilder.DropTable(
                name: "Modele");

            migrationBuilder.DropTable(
                name: "Armie");

            migrationBuilder.DropTable(
                name: "Dywizja");

            migrationBuilder.DropTable(
                name: "Stopnie");
        }
    }
}
