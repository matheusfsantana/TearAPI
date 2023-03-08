using System;
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
                    QuebraDeUrdume = table.Column<int>(type: "INTEGER", nullable: false),
                    QuebraDeTrama = table.Column<int>(type: "INTEGER", nullable: false),
                    FimDeTrama = table.Column<int>(type: "INTEGER", nullable: false),
                    TempoLigado = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TempoParado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teares", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teares");
        }
    }
}
