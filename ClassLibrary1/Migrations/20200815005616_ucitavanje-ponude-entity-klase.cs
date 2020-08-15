using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class ucitavanjeponudeentityklase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipProizvoda",
                columns: table => new
                {
                    TipProizvodaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipProizvoda", x => x.TipProizvodaID);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    ulogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nazivUloge = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.ulogaID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UlogaID = table.Column<int>(nullable: false),
                    ime = table.Column<string>(nullable: false),
                    prezime = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    brojTelefona = table.Column<string>(nullable: false),
                    adresaStanovanja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userID);
                    table.ForeignKey(
                        name: "FK_User_Uloga_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloga",
                        principalColumn: "ulogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Slika",
                columns: table => new
                {
                    SlikaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    slika = table.Column<byte[]>(nullable: true),
                    datumPostavljanja = table.Column<DateTime>(nullable: false),
                    userID = table.Column<int>(nullable: false),
                    lokacijaSlike = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slika", x => x.SlikaID);
                    table.ForeignKey(
                        name: "FK_Slika_User_userID",
                        column: x => x.userID,
                        principalTable: "User",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    slikaID = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(maxLength: 30, nullable: false),
                    Opis = table.Column<string>(maxLength: 100, nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    TipProizvodaID = table.Column<int>(nullable: false),
                    userID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvod_TipProizvoda_TipProizvodaID",
                        column: x => x.TipProizvodaID,
                        principalTable: "TipProizvoda",
                        principalColumn: "TipProizvodaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_Slika_slikaID",
                        column: x => x.slikaID,
                        principalTable: "Slika",
                        principalColumn: "SlikaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_User_userID",
                        column: x => x.userID,
                        principalTable: "User",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_TipProizvodaID",
                table: "Proizvod",
                column: "TipProizvodaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_slikaID",
                table: "Proizvod",
                column: "slikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_userID",
                table: "Proizvod",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Slika_userID",
                table: "Slika",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UlogaID",
                table: "User",
                column: "UlogaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "TipProizvoda");

            migrationBuilder.DropTable(
                name: "Slika");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Uloga");
        }
    }
}
