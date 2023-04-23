using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE6.Inheritance.Migrations
{
    public partial class updateTbls2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "PersonManagers",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "PersonManagers",
                newName: "Yas");

            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "PersonEmployees",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "PersonEmployees",
                newName: "Yas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yas",
                table: "PersonManagers",
                newName: "Person_Age");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonManagers",
                newName: "Person_Name");

            migrationBuilder.RenameColumn(
                name: "Yas",
                table: "PersonEmployees",
                newName: "Person_Age");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonEmployees",
                newName: "Person_Name");
        }
    }
}
