using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class attributesnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Attributes_ServiceId",
                table: "Attributes",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attributes_Services_ServiceId",
                table: "Attributes",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attributes_Services_ServiceId",
                table: "Attributes");

            migrationBuilder.DropIndex(
                name: "IX_Attributes_ServiceId",
                table: "Attributes");
        }
    }
}
