using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class nno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalNoOfRooms",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "CarsRate",
                table: "Services",
                newName: "TotalNoOfRoom");

            migrationBuilder.AlterColumn<string>(
                name: "OpeningHours",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarRate",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarRate",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "TotalNoOfRoom",
                table: "Services",
                newName: "CarsRate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OpeningHours",
                table: "Services",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalNoOfRooms",
                table: "Services",
                type: "int",
                nullable: true);
        }
    }
}
