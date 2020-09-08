using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class nova_baza_rezervacija_dodavanje_klasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userID",
                table: "User",
                newName: "UserID");

            migrationBuilder.CreateTable(
                name: "BrojOsoba",
                columns: table => new
                {
                    BrojOsobaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    brOsoba = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrojOsoba", x => x.BrojOsobaID);
                });

            migrationBuilder.CreateTable(
                name: "KapacitetStola",
                columns: table => new
                {
                    KapacitetStolaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    minBrStolica = table.Column<int>(nullable: false),
                    maxBrStolica = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KapacitetStola", x => x.KapacitetStolaID);
                });

            migrationBuilder.CreateTable(
                name: "Poslovnica",
                columns: table => new
                {
                    PoslovnicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslovnica", x => x.PoslovnicaID);
                    table.ForeignKey(
                        name: "FK_Poslovnica_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminRezervacije",
                columns: table => new
                {
                    TerminRezervacijeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    terminRez = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminRezervacije", x => x.TerminRezervacijeID);
                });

            migrationBuilder.CreateTable(
                name: "Stol",
                columns: table => new
                {
                    StolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dostupan = table.Column<bool>(nullable: false),
                    PoslovnicaID = table.Column<int>(nullable: true),
                    TipProizvodaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stol", x => x.StolID);
                    table.ForeignKey(
                        name: "FK_Stol_Poslovnica_PoslovnicaID",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stol_TipProizvoda_TipProizvodaID",
                        column: x => x.TipProizvodaID,
                        principalTable: "TipProizvoda",
                        principalColumn: "TipProizvodaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    RezervacijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(maxLength: 64, nullable: true),
                    Prezime = table.Column<string>(maxLength: 64, nullable: true),
                    BrojTelefona = table.Column<string>(maxLength: 64, nullable: true),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    DatumRezervacije = table.Column<string>(nullable: true),
                    VrijemeZahtjeva = table.Column<DateTime>(nullable: false),
                    Napomena = table.Column<string>(maxLength: 256, nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    TerminRezervacijeID = table.Column<int>(nullable: true),
                    PoslovnicaID = table.Column<int>(nullable: true),
                    BrojOsobaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => x.RezervacijaID);
                    table.ForeignKey(
                        name: "FK_Rezervacija_BrojOsoba_BrojOsobaID",
                        column: x => x.BrojOsobaID,
                        principalTable: "BrojOsoba",
                        principalColumn: "BrojOsobaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Poslovnica_PoslovnicaID",
                        column: x => x.PoslovnicaID,
                        principalTable: "Poslovnica",
                        principalColumn: "PoslovnicaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_TerminRezervacije_TerminRezervacijeID",
                        column: x => x.TerminRezervacijeID,
                        principalTable: "TerminRezervacije",
                        principalColumn: "TerminRezervacijeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poslovnica_UserID",
                table: "Poslovnica",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_BrojOsobaID",
                table: "Rezervacija",
                column: "BrojOsobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_PoslovnicaID",
                table: "Rezervacija",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_TerminRezervacijeID",
                table: "Rezervacija",
                column: "TerminRezervacijeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_UserID",
                table: "Rezervacija",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Stol_PoslovnicaID",
                table: "Stol",
                column: "PoslovnicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Stol_TipProizvodaID",
                table: "Stol",
                column: "TipProizvodaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KapacitetStola");

            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Stol");

            migrationBuilder.DropTable(
                name: "BrojOsoba");

            migrationBuilder.DropTable(
                name: "TerminRezervacije");

            migrationBuilder.DropTable(
                name: "Poslovnica");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "userID");
        }
    }
}
