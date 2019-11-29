using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class inspeccioncolgandodepajera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PajeraId",
                table: "Inspeccion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Inspeccion_PajeraId",
                table: "Inspeccion",
                column: "PajeraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inspeccion_Pajera_PajeraId",
                table: "Inspeccion",
                column: "PajeraId",
                principalTable: "Pajera",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inspeccion_Pajera_PajeraId",
                table: "Inspeccion");

            migrationBuilder.DropIndex(
                name: "IX_Inspeccion_PajeraId",
                table: "Inspeccion");

            migrationBuilder.DropColumn(
                name: "PajeraId",
                table: "Inspeccion");
        }
    }
}
