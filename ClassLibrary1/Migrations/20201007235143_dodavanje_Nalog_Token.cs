using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class dodavanje_Nalog_Token : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "NalogID",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Nalog",
                columns: table => new
                {
                    NalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 128, nullable: false),
                    Lozinka = table.Column<string>(maxLength: 50, nullable: false),
                    DatumKreiranja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalog", x => x.NalogID);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    TokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Vrijednost = table.Column<string>(nullable: false),
                    NalogID = table.Column<int>(nullable: true),
                    VrijemeKreiranja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.TokenID);
                    table.ForeignKey(
                        name: "FK_Token_Nalog_NalogID",
                        column: x => x.NalogID,
                        principalTable: "Nalog",
                        principalColumn: "NalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_NalogID",
                table: "User",
                column: "NalogID");

            migrationBuilder.CreateIndex(
                name: "IX_Token_NalogID",
                table: "Token",
                column: "NalogID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Nalog_NalogID",
                table: "User",
                column: "NalogID",
                principalTable: "Nalog",
                principalColumn: "NalogID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Nalog_NalogID",
                table: "User");

            migrationBuilder.DropTable(
                name: "Token");

            migrationBuilder.DropTable(
                name: "Nalog");

            migrationBuilder.DropIndex(
                name: "IX_User_NalogID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NalogID",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "User",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }
    }
}
