using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class druga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zolnierze_Dywizja_Id",
                table: "Zolnierze");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dywizja",
                table: "Dywizja");

            migrationBuilder.RenameTable(
                name: "Dywizja",
                newName: "Dywizje");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dywizje",
                table: "Dywizje",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Zolnierze_Dywizje_Id",
                table: "Zolnierze",
                column: "Id",
                principalTable: "Dywizje",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zolnierze_Dywizje_Id",
                table: "Zolnierze");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dywizje",
                table: "Dywizje");

            migrationBuilder.RenameTable(
                name: "Dywizje",
                newName: "Dywizja");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dywizja",
                table: "Dywizja",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Zolnierze_Dywizja_Id",
                table: "Zolnierze",
                column: "Id",
                principalTable: "Dywizja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
