using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE6.Inheritance.Migrations
{
    public partial class updateTbls4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Person_SurName",
                table: "PersonManagers",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Person_SurName",
                table: "PersonEmployees",
                newName: "Ad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonManagers",
                newName: "Person_SurName");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonEmployees",
                newName: "Person_SurName");
        }
    }
}
