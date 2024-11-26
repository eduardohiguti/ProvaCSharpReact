using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    TarefaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.TarefaId);
                    table.ForeignKey(
                        name: "FK_Tarefas_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId");
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CriadoEm", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 26, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1273), "Trabalho" },
                    { 2, new DateTime(2024, 11, 27, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1280), "Estudos" },
                    { 3, new DateTime(2024, 11, 28, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1281), "Lazer" }
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 2, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1386), "Terminar relatório para reunião", "Não iniciada", "Concluir relatório" },
                    { 2, 2, new DateTime(2024, 11, 28, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1388), "Preparar-se para a aula de Angular", "Não iniciada", "Estudar Angular" },
                    { 3, 3, new DateTime(2024, 12, 9, 21, 33, 31, 156, DateTimeKind.Local).AddTicks(1390), "Dar um passeio relaxante no parque", "Não iniciada", "Passeio no parque" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_CategoriaId",
                table: "Tarefas",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
