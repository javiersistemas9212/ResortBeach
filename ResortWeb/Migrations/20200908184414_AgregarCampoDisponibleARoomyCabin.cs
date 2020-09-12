using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResortWeb.Migrations
{
    public partial class AgregarCampoDisponibleARoomyCabin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AddUserViewModel");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Rooms",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Cabins",
                nullable: false,
                defaultValue: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Cabins");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AddUserViewModel",
                maxLength: 100,
                nullable: true);
        }
    }
}
