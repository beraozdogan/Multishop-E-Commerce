using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MultiShop.Order.Persistence.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Adresses",
                newName: "ZipCode");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Detail1",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Detail2",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Detail1",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Detail2",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Adresses",
                newName: "Detail");
        }
    }
}
