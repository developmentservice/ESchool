using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ESchool.Data.Migrations
{
    public partial class creating_new_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirsName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MidleName = table.Column<string>(nullable: true),
                    Addres = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolEvents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalMains",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    schoolEventId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalMains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalMains_SchoolEvents_schoolEventId",
                        column: x => x.schoolEventId,
                        principalTable: "SchoolEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JournalRaits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jurnalMainId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    Rait = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalRaits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalRaits_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournalRaits_JournalMains_jurnalMainId",
                        column: x => x.jurnalMainId,
                        principalTable: "JournalMains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JournaPresents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jurnalMainId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    Present = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournaPresents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournaPresents_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JournaPresents_JournalMains_jurnalMainId",
                        column: x => x.jurnalMainId,
                        principalTable: "JournalMains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JournalMains_schoolEventId",
                table: "JournalMains",
                column: "schoolEventId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalRaits_PersonId",
                table: "JournalRaits",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalRaits_jurnalMainId",
                table: "JournalRaits",
                column: "jurnalMainId");

            migrationBuilder.CreateIndex(
                name: "IX_JournaPresents_PersonId",
                table: "JournaPresents",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_JournaPresents_jurnalMainId",
                table: "JournaPresents",
                column: "jurnalMainId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JournalRaits");

            migrationBuilder.DropTable(
                name: "JournaPresents");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "JournalMains");

            migrationBuilder.DropTable(
                name: "SchoolEvents");
        }
    }
}
