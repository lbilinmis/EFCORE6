using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE6.Inheritance.Migrations
{
    public partial class indexleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Yas",
                table: "PersonManagers",
                newName: "Person_Age");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "PersonManagers",
                newName: "Person_SurName");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonManagers",
                newName: "Person_Name");

            migrationBuilder.RenameColumn(
                name: "Yas",
                table: "PersonEmployees",
                newName: "Person_Age");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "PersonEmployees",
                newName: "Person_SurName");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "PersonEmployees",
                newName: "Person_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name_Barcode",
                table: "Products",
                columns: new[] { "Name", "Barcode" })
                .Annotation("SqlServer:Include", new[] { "Price", "Stock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Name_Barcode",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Person_SurName",
                table: "PersonManagers",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "PersonManagers",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "PersonManagers",
                newName: "Yas");

            migrationBuilder.RenameColumn(
                name: "Person_SurName",
                table: "PersonEmployees",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "Person_Name",
                table: "PersonEmployees",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "Person_Age",
                table: "PersonEmployees",
                newName: "Yas");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Barcode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
