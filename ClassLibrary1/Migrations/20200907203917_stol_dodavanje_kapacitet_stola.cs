using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class stol_dodavanje_kapacitet_stola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stol_TipProizvoda_TipProizvodaID",
                table: "Stol");

            migrationBuilder.RenameColumn(
                name: "TipProizvodaID",
                table: "Stol",
                newName: "KapacitetStolaID");

            migrationBuilder.RenameIndex(
                name: "IX_Stol_TipProizvodaID",
                table: "Stol",
                newName: "IX_Stol_KapacitetStolaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stol_KapacitetStola_KapacitetStolaID",
                table: "Stol",
                column: "KapacitetStolaID",
                principalTable: "KapacitetStola",
                principalColumn: "KapacitetStolaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stol_KapacitetStola_KapacitetStolaID",
                table: "Stol");

            migrationBuilder.RenameColumn(
                name: "KapacitetStolaID",
                table: "Stol",
                newName: "TipProizvodaID");

            migrationBuilder.RenameIndex(
                name: "IX_Stol_KapacitetStolaID",
                table: "Stol",
                newName: "IX_Stol_TipProizvodaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stol_TipProizvoda_TipProizvodaID",
                table: "Stol",
                column: "TipProizvodaID",
                principalTable: "TipProizvoda",
                principalColumn: "TipProizvodaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
