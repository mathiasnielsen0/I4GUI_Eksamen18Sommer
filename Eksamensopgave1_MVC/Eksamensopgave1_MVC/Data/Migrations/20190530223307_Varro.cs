using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamensopgave1_MVC.Data.Migrations
{
    public partial class Varro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Varros",
                columns: table => new
                {
                    VarroId = table.Column<string>(nullable: false),
                    Bistade = table.Column<string>(nullable: false),
                    DatoRegistreret = table.Column<DateTime>(nullable: false),
                    AntalMider = table.Column<long>(nullable: false),
                    ObservationsVarighed = table.Column<long>(nullable: false),
                    Notater = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varros", x => x.VarroId);
                    table.ForeignKey(
                        name: "FK_Varros_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Varros_ApplicationUserId",
                table: "Varros",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Varros");
        }
    }
}
