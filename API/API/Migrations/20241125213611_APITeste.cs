using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class APITeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 28, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 27, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 26, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 28, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 12, 2, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 12, 9, 18, 36, 10, 724, DateTimeKind.Local).AddTicks(9600));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 28, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 27, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 26, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 11, 28, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 12, 2, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 12, 9, 18, 18, 23, 365, DateTimeKind.Local).AddTicks(928));
        }
    }
}
