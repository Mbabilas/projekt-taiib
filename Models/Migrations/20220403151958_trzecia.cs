using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class trzecia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Dywizje",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dywizje_Armie_Id",
                table: "Dywizje",
                column: "Id",
                principalTable: "Armie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dywizje_Armie_Id",
                table: "Dywizje");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Dywizje",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
