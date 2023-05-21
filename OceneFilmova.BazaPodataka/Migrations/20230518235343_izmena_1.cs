using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OceneFilmova.BazaPodataka.Migrations
{
    /// <inheritdoc />
    public partial class izmena_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Glumci_Filmovi_FilmID",
                table: "Glumci");

            migrationBuilder.DropIndex(
                name: "IX_Glumci_FilmID",
                table: "Glumci");

            migrationBuilder.DropColumn(
                name: "FilmID",
                table: "Glumci");

            migrationBuilder.CreateTable(
                name: "FilmGlumac",
                columns: table => new
                {
                    FilmoviID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GlumciID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGlumac", x => new { x.FilmoviID, x.GlumciID });
                    table.ForeignKey(
                        name: "FK_FilmGlumac_Filmovi_FilmoviID",
                        column: x => x.FilmoviID,
                        principalTable: "Filmovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmGlumac_Glumci_GlumciID",
                        column: x => x.GlumciID,
                        principalTable: "Glumci",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmGlumac_GlumciID",
                table: "FilmGlumac",
                column: "GlumciID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGlumac");

            migrationBuilder.AddColumn<Guid>(
                name: "FilmID",
                table: "Glumci",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Glumci_FilmID",
                table: "Glumci",
                column: "FilmID");

            migrationBuilder.AddForeignKey(
                name: "FK_Glumci_Filmovi_FilmID",
                table: "Glumci",
                column: "FilmID",
                principalTable: "Filmovi",
                principalColumn: "ID");
        }
    }
}
