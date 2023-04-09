using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class alldat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomRate",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Attributes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Attributes");

            migrationBuilder.AlterColumn<decimal>(
                name: "RoomRate",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
