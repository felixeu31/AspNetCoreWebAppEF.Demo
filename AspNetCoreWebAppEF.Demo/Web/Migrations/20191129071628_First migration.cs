using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspeccion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspeccion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pajera",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pajera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubPajera",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PajeraId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPajera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubPajera_Pajera_PajeraId",
                        column: x => x.PajeraId,
                        principalTable: "Pajera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adjunto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PajeraId = table.Column<int>(nullable: true),
                    SubPajeraId = table.Column<int>(nullable: true),
                    InspeccionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adjunto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adjunto_Inspeccion_InspeccionId",
                        column: x => x.InspeccionId,
                        principalTable: "Inspeccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adjunto_Pajera_PajeraId",
                        column: x => x.PajeraId,
                        principalTable: "Pajera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adjunto_SubPajera_SubPajeraId",
                        column: x => x.SubPajeraId,
                        principalTable: "SubPajera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adjunto_InspeccionId",
                table: "Adjunto",
                column: "InspeccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Adjunto_PajeraId",
                table: "Adjunto",
                column: "PajeraId");

            migrationBuilder.CreateIndex(
                name: "IX_Adjunto_SubPajeraId",
                table: "Adjunto",
                column: "SubPajeraId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPajera_PajeraId",
                table: "SubPajera",
                column: "PajeraId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adjunto");

            migrationBuilder.DropTable(
                name: "Inspeccion");

            migrationBuilder.DropTable(
                name: "SubPajera");

            migrationBuilder.DropTable(
                name: "Pajera");
        }
    }
}
