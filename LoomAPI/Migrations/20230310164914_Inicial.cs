using Microsoft.EntityFrameworkCore.Migrations;

namespace LoomAPI.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Eficiencia = table.Column<string>(type: "TEXT", nullable: true),
                    TempoParado = table.Column<string>(type: "TEXT", nullable: true),
                    TempoLigado = table.Column<string>(type: "TEXT", nullable: true),
                    TempoInicial = table.Column<string>(type: "TEXT", nullable: true),
                    TempoFinal = table.Column<string>(type: "TEXT", nullable: true),
                    TempoDecorrido = table.Column<string>(type: "TEXT", nullable: true),
                    HoraDeLigacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Erros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuantidadeParadas = table.Column<int>(type: "INTEGER", nullable: false),
                    TempoParadas = table.Column<string>(type: "TEXT", nullable: true),
                    PerdaEficienciaParadas = table.Column<string>(type: "TEXT", nullable: true),
                    TempoMedio = table.Column<string>(type: "TEXT", nullable: true),
                    TearId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Erros_Teares_TearId",
                        column: x => x.TearId,
                        principalTable: "Teares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Erros_TearId",
                table: "Erros",
                column: "TearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Erros");

            migrationBuilder.DropTable(
                name: "Teares");
        }
    }
}
