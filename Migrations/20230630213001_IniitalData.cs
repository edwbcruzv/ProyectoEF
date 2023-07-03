using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectEF.Migrations
{
    /// <inheritdoc />
    public partial class IniitalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[,]
                {
                    { new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b01"), null, "Actividades personales", 21 },
                    { new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7be6"), null, "Actividades pendientes", 20 }
                });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[,]
                {
                    { new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b10"), new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7be6"), null, new DateTime(2023, 6, 30, 15, 30, 1, 47, DateTimeKind.Local).AddTicks(9495), 1, "Servicios publicos" },
                    { new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b22"), new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b01"), null, new DateTime(2023, 6, 30, 15, 30, 1, 47, DateTimeKind.Local).AddTicks(9515), 0, "Peliculas en Netflix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b10"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b22"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b01"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7be6"));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
