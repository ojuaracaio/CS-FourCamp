using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_Exemplo.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dt_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Especie = table.Column<int>(type: "int", nullable: false),
                    Castrado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Animal");
        }
    }
}
