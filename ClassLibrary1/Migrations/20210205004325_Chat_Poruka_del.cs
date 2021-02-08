using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class Chat_Poruka_del : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poruka");

            migrationBuilder.DropTable(
                name: "Chat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ChatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnickaSluzbaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    VrijemePocetka = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ChatID);
                    table.ForeignKey(
                        name: "FK_Chat_User_KorisnickaSluzbaID",
                        column: x => x.KorisnickaSluzbaID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chat_User_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poruka",
                columns: table => new
                {
                    PorukaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChatID = table.Column<int>(nullable: false),
                    PosijateljID = table.Column<int>(nullable: false),
                    PosiljateljUserID = table.Column<int>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    VrijemeSlanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.PorukaID);
                    table.ForeignKey(
                        name: "FK_Poruka_Chat_ChatID",
                        column: x => x.ChatID,
                        principalTable: "Chat",
                        principalColumn: "ChatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Poruka_User_PosiljateljUserID",
                        column: x => x.PosiljateljUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_KorisnickaSluzbaID",
                table: "Chat",
                column: "KorisnickaSluzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_KorisnikID",
                table: "Chat",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_ChatID",
                table: "Poruka",
                column: "ChatID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PosiljateljUserID",
                table: "Poruka",
                column: "PosiljateljUserID");
        }
    }
}
