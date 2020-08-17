using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class dodavanje_foreignID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_User_userID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Slika_User_userID",
                table: "Slika");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Uloga_ulogaID",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "ulogaID",
                table: "User",
                newName: "UlogaID");

            migrationBuilder.RenameIndex(
                name: "IX_User_ulogaID",
                table: "User",
                newName: "IX_User_UlogaID");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Slika",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Slika_userID",
                table: "Slika",
                newName: "IX_Slika_UserID");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Proizvod",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_userID",
                table: "Proizvod",
                newName: "IX_Proizvod_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_User_UserID",
                table: "Proizvod",
                column: "UserID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_User_UserID",
                table: "Slika",
                column: "UserID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Uloga_UlogaID",
                table: "User",
                column: "UlogaID",
                principalTable: "Uloga",
                principalColumn: "ulogaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_User_UserID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Slika_User_UserID",
                table: "Slika");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Uloga_UlogaID",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UlogaID",
                table: "User",
                newName: "ulogaID");

            migrationBuilder.RenameIndex(
                name: "IX_User_UlogaID",
                table: "User",
                newName: "IX_User_ulogaID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Slika",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_Slika_UserID",
                table: "Slika",
                newName: "IX_Slika_userID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Proizvod",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_UserID",
                table: "Proizvod",
                newName: "IX_Proizvod_userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_User_userID",
                table: "Proizvod",
                column: "userID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_User_userID",
                table: "Slika",
                column: "userID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Uloga_ulogaID",
                table: "User",
                column: "ulogaID",
                principalTable: "Uloga",
                principalColumn: "ulogaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
