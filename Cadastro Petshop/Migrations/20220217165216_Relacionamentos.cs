using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_Petshop.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlanoId",
                table: "TB_Animal",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TB_ContratoTrabalho",
                columns: table => new
                {
                    ContratoTrabalhoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Contratacao = table.Column<DateTime>(type: "Date", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ContratoTrabalho", x => x.ContratoTrabalhoId);
                });

            migrationBuilder.CreateTable(
                name: "TB_Plano",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContratoTrabalhoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Veterinario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_Veterinario_TB_ContratoTrabalho_ContratoTrabalhoId",
                        column: x => x.ContratoTrabalhoId,
                        principalTable: "TB_ContratoTrabalho",
                        principalColumn: "ContratoTrabalhoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_AnimalVeterinario",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    VeterinarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_AnimalVeterinario", x => new { x.AnimalId, x.VeterinarioId });
                    table.ForeignKey(
                        name: "FK_TB_AnimalVeterinario_TB_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "TB_Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_AnimalVeterinario_TB_Veterinario_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "TB_Veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Animal_PlanoId",
                table: "TB_Animal",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_AnimalVeterinario_VeterinarioId",
                table: "TB_AnimalVeterinario",
                column: "VeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Veterinario_ContratoTrabalhoId",
                table: "TB_Veterinario",
                column: "ContratoTrabalhoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal",
                column: "PlanoId",
                principalTable: "TB_Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal");

            migrationBuilder.DropTable(
                name: "TB_AnimalVeterinario");

            migrationBuilder.DropTable(
                name: "TB_Plano");

            migrationBuilder.DropTable(
                name: "TB_Veterinario");

            migrationBuilder.DropTable(
                name: "TB_ContratoTrabalho");

            migrationBuilder.DropIndex(
                name: "IX_TB_Animal_PlanoId",
                table: "TB_Animal");

            migrationBuilder.DropColumn(
                name: "PlanoId",
                table: "TB_Animal");
        }
    }
}
