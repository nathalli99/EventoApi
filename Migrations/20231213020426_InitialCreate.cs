using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventoApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_EVENTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Classe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EVENTOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_EVENTOS",
                columns: new[] { "Id", "Artista", "Classe", "Data", "Local", "Nome" },
                values: new object[,]
                {
                    { 1, "NCT 127", 1, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Vibra", "Neo City: The Link Tour" },
                    { 2, "NCT DREAM", 1, new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Vibra", "The Dream Show II: In A Dream" },
                    { 3, "ATEEZ", 1, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Allianz Parque", "The Fellowship: Break the Wall Tour" },
                    { 4, "Bruno Mars, Post Malone...", 2, new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Autódromo de Interlagos", "THE TOWN" },
                    { 5, "aespa", 1, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Espaço Unimed", "Synk: Hyper Line Tour" },
                    { 6, "Evanescence", 1, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Allianz Parque", "South American Tour" },
                    { 7, "RBD", 1, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Allianz Parque", "Soy Rebelde Tour" },
                    { 8, "Taylor Swift", 1, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Allianz Parque", "The Eras Tour" },
                    { 9, "TWICE", 1, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Allianz Parque", "Ready To Be" },
                    { 10, "IVE", 1, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "São Paulo, Espaço Unimed", "SHOW WHAT I HAVE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_EVENTOS");
        }
    }
}
