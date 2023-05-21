using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OceneFilmova.BazaPodataka.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmovi",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GodinaIzdanja = table.Column<int>(type: "int", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deskripcija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmovi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tagovi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tagovi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Glumci",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glumci", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Glumci_Filmovi_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Filmovi",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FilmTag",
                columns: table => new
                {
                    FilmoviID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagoviID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTag", x => new { x.FilmoviID, x.TagoviID });
                    table.ForeignKey(
                        name: "FK_FilmTag_Filmovi_FilmoviID",
                        column: x => x.FilmoviID,
                        principalTable: "Filmovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmTag_Tagovi_TagoviID",
                        column: x => x.TagoviID,
                        principalTable: "Tagovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmTag_TagoviID",
                table: "FilmTag",
                column: "TagoviID");

            migrationBuilder.CreateIndex(
                name: "IX_Glumci_FilmID",
                table: "Glumci",
                column: "FilmID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmTag");

            migrationBuilder.DropTable(
                name: "Glumci");

            migrationBuilder.DropTable(
                name: "Tagovi");

            migrationBuilder.DropTable(
                name: "Filmovi");
        }
    }
}
