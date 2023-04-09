using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class nnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalNoOfRoom",
                table: "Services",
                newName: "TotalNoOfRooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalNoOfRooms",
                table: "Services",
                newName: "TotalNoOfRoom");
        }
    }
}
