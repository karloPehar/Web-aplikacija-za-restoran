using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class Chat_Poruka_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_KorisnikID",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_Poruka_User_PosiljateljUserID",
                table: "Poruka");

            migrationBuilder.DropIndex(
                name: "IX_Poruka_PosiljateljUserID",
                table: "Poruka");

            migrationBuilder.DropColumn(
                name: "PosiljateljUserID",
                table: "Poruka");

            migrationBuilder.RenameColumn(
                name: "PosijateljID",
                table: "Poruka",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Chat",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_KorisnikID",
                table: "Chat",
                newName: "IX_Chat_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_UserID",
                table: "Poruka",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_UserID",
                table: "Chat",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Poruka_User_UserID",
                table: "Poruka",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chat_User_UserID",
                table: "Chat");

            migrationBuilder.DropForeignKey(
                name: "FK_Poruka_User_UserID",
                table: "Poruka");

            migrationBuilder.DropIndex(
                name: "IX_Poruka_UserID",
                table: "Poruka");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Poruka",
                newName: "PosijateljID");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Chat",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Chat_UserID",
                table: "Chat",
                newName: "IX_Chat_KorisnikID");

            migrationBuilder.AddColumn<int>(
                name: "PosiljateljUserID",
                table: "Poruka",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PosiljateljUserID",
                table: "Poruka",
                column: "PosiljateljUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Chat_User_KorisnikID",
                table: "Chat",
                column: "KorisnikID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Poruka_User_PosiljateljUserID",
                table: "Poruka",
                column: "PosiljateljUserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
