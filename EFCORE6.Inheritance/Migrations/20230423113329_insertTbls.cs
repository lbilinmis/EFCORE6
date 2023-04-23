using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE6.Inheritance.Migrations
{
    public partial class insertTbls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person_SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person_Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEmployees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonManagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person_SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Person_Age = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonManagers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonEmployees");

            migrationBuilder.DropTable(
                name: "PersonManagers");
        }
    }
}
