using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_Petshop.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: true),
                    Especie = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Castrado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Animal", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Animal");
        }
    }
}
