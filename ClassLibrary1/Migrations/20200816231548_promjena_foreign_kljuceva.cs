using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class promjena_foreign_kljuceva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_TipProizvoda_TipProizvodaID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Slika_slikaID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_User_userID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Slika_User_userID",
                table: "Slika");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Uloga_UlogaID",
                table: "User");

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

            migrationBuilder.RenameColumn(
                name: "slikaID",
                table: "Proizvod",
                newName: "SlikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_userID",
                table: "Proizvod",
                newName: "IX_Proizvod_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_slikaID",
                table: "Proizvod",
                newName: "IX_Proizvod_SlikaID");

            migrationBuilder.AlterColumn<string>(
                name: "prezime",
                table: "User",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ime",
                table: "User",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "User",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "brojTelefona",
                table: "User",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "adresaStanovanja",
                table: "User",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UlogaID",
                table: "User",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Slika",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Proizvod",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SlikaID",
                table: "Proizvod",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TipProizvodaID",
                table: "Proizvod",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Proizvod",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvod",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Slika_SlikaID",
                table: "Proizvod",
                column: "SlikaID",
                principalTable: "Slika",
                principalColumn: "SlikaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_TipProizvoda_TipProizvodaID",
                table: "Proizvod",
                column: "TipProizvodaID",
                principalTable: "TipProizvoda",
                principalColumn: "TipProizvodaID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Proizvod_Slika_SlikaID",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_TipProizvoda_TipProizvodaID",
                table: "Proizvod");

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

            migrationBuilder.RenameColumn(
                name: "SlikaID",
                table: "Proizvod",
                newName: "slikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_UserID",
                table: "Proizvod",
                newName: "IX_Proizvod_userID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_SlikaID",
                table: "Proizvod",
                newName: "IX_Proizvod_slikaID");

            migrationBuilder.AlterColumn<string>(
                name: "prezime",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "ime",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "brojTelefona",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "adresaStanovanja",
                table: "User",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<int>(
                name: "UlogaID",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "Slika",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "Proizvod",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipProizvodaID",
                table: "Proizvod",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "slikaID",
                table: "Proizvod",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Proizvod",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvod",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_TipProizvoda_TipProizvodaID",
                table: "Proizvod",
                column: "TipProizvodaID",
                principalTable: "TipProizvoda",
                principalColumn: "TipProizvodaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Slika_slikaID",
                table: "Proizvod",
                column: "slikaID",
                principalTable: "Slika",
                principalColumn: "SlikaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_User_userID",
                table: "Proizvod",
                column: "userID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_User_userID",
                table: "Slika",
                column: "userID",
                principalTable: "User",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Uloga_UlogaID",
                table: "User",
                column: "UlogaID",
                principalTable: "Uloga",
                principalColumn: "ulogaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
