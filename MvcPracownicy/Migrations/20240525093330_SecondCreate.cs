using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcPracownicy.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GodzinyNauki",
                columns: table => new
                {
                    IDucznia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jezyk = table.Column<string>(type: "TEXT", nullable: false),
                    Godziny = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodzinyNauki", x => x.IDucznia);
                });

            migrationBuilder.CreateTable(
                name: "Grupa",
                columns: table => new
                {
                    IDgrupy = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    PracownikIDpracownika = table.Column<int>(type: "INTEGER", nullable: false),
                    Jezyk = table.Column<string>(type: "TEXT", nullable: false),
                    LiczbaUczestnikow = table.Column<int>(type: "INTEGER", nullable: false),
                    DataRozpoczecia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupa", x => x.IDgrupy);
                    table.ForeignKey(
                        name: "FK_Grupa_Pracownik_PracownikIDpracownika",
                        column: x => x.PracownikIDpracownika,
                        principalTable: "Pracownik",
                        principalColumn: "IDpracownika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IDucznia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(type: "TEXT", nullable: false),
                    Nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    DataDolaczenia = table.Column<DateTime>(type: "TEXT", nullable: false),
                    GrupaIDgrupy = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IDucznia);
                    table.ForeignKey(
                        name: "FK_Student_Grupa_GrupaIDgrupy",
                        column: x => x.GrupaIDgrupy,
                        principalTable: "Grupa",
                        principalColumn: "IDgrupy");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupa_PracownikIDpracownika",
                table: "Grupa",
                column: "PracownikIDpracownika");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GrupaIDgrupy",
                table: "Student",
                column: "GrupaIDgrupy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GodzinyNauki");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Grupa");
        }
    }
}
