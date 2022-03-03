using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_Petshop.Migrations
{
    public partial class AdicionarChaveData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_AnimalVeterinario",
                table: "TB_AnimalVeterinario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_Animal",
                newName: "AnimalID");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "TB_AnimalVeterinario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "PlanoId",
                table: "TB_Animal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_AnimalVeterinario",
                table: "TB_AnimalVeterinario",
                columns: new[] { "AnimalId", "VeterinarioId", "Data" });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal",
                column: "PlanoId",
                principalTable: "TB_Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_AnimalVeterinario",
                table: "TB_AnimalVeterinario");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "TB_AnimalVeterinario");

            migrationBuilder.RenameColumn(
                name: "AnimalID",
                table: "TB_Animal",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "PlanoId",
                table: "TB_Animal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_AnimalVeterinario",
                table: "TB_AnimalVeterinario",
                columns: new[] { "AnimalId", "VeterinarioId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_Animal_TB_Plano_PlanoId",
                table: "TB_Animal",
                column: "PlanoId",
                principalTable: "TB_Plano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
