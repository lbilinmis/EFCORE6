using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE6.Inheritance.Migrations
{
    public partial class updateTbls3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonManagers",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonEmployees",
                newName: "Soyad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "PersonManagers",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "PersonEmployees",
                newName: "Ad");
        }
    }
}
