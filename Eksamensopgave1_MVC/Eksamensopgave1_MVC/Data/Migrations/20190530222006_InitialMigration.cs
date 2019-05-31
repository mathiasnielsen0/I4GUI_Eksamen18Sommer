using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamensopgave1_MVC.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddresseLinje1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddresseLinje2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "By",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DBFnummer",
                table: "AspNetUsers",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Efternavn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fornavn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Postnummer",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddresseLinje1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddresseLinje2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "By",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DBFnummer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Efternavn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Fornavn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Postnummer",
                table: "AspNetUsers");
        }
    }
}
