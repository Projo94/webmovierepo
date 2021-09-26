using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Movies.Persistance.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    IDActor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.IDActor);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    IDRating = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfStars = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.IDRating);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfPrograms",
                columns: table => new
                {
                    IDTypeOfProgram = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfPrograms", x => x.IDTypeOfProgram);
                });

            migrationBuilder.CreateTable(
                name: "TVPrograms",
                columns: table => new
                {
                    IDTVProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PictureDisplay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfProgramID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVPrograms", x => x.IDTVProgram);
                    table.ForeignKey(
                        name: "FK_TVPrograms_TypeOfPrograms_TypeOfProgramID",
                        column: x => x.TypeOfProgramID,
                        principalTable: "TypeOfPrograms",
                        principalColumn: "IDTypeOfProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorTVPrograms",
                columns: table => new
                {
                    IDTVProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDActor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorTVPrograms", x => new { x.IDTVProgram, x.IDActor });
                    table.ForeignKey(
                        name: "FK_ActorTVPrograms_Actors_IDActor",
                        column: x => x.IDActor,
                        principalTable: "Actors",
                        principalColumn: "IDActor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorTVPrograms_TVPrograms_IDTVProgram",
                        column: x => x.IDTVProgram,
                        principalTable: "TVPrograms",
                        principalColumn: "IDTVProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TVProgramRatings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTVProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVProgramRatings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TVProgramRatings_Ratings_IDRating",
                        column: x => x.IDRating,
                        principalTable: "Ratings",
                        principalColumn: "IDRating",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TVProgramRatings_TVPrograms_IDTVProgram",
                        column: x => x.IDTVProgram,
                        principalTable: "TVPrograms",
                        principalColumn: "IDTVProgram",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "IDRating", "NumberOfStars" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "TypeOfPrograms",
                columns: new[] { "IDTypeOfProgram", "Caption" },
                values: new object[,]
                {
                    { 1, "TV Show" },
                    { 2, "Movie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorTVPrograms_IDActor",
                table: "ActorTVPrograms",
                column: "IDActor");

            migrationBuilder.CreateIndex(
                name: "IX_TVProgramRatings_IDRating",
                table: "TVProgramRatings",
                column: "IDRating");

            migrationBuilder.CreateIndex(
                name: "IX_TVProgramRatings_IDTVProgram",
                table: "TVProgramRatings",
                column: "IDTVProgram");

            migrationBuilder.CreateIndex(
                name: "IX_TVPrograms_TypeOfProgramID",
                table: "TVPrograms",
                column: "TypeOfProgramID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorTVPrograms");

            migrationBuilder.DropTable(
                name: "TVProgramRatings");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "TVPrograms");

            migrationBuilder.DropTable(
                name: "TypeOfPrograms");
        }
    }
}
