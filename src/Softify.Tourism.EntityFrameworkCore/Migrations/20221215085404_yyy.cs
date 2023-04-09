using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class yyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeService_Attributes_AttributeId",
                table: "AttributeService");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeService_Services_ServiceId",
                table: "AttributeService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeService",
                table: "AttributeService");

            migrationBuilder.RenameTable(
                name: "AttributeService",
                newName: "AttributeServices");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeService_ServiceId",
                table: "AttributeServices",
                newName: "IX_AttributeServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeService_AttributeId",
                table: "AttributeServices",
                newName: "IX_AttributeServices_AttributeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeServices",
                table: "AttributeServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeServices_Attributes_AttributeId",
                table: "AttributeServices",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeServices_Services_ServiceId",
                table: "AttributeServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeServices_Attributes_AttributeId",
                table: "AttributeServices");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeServices_Services_ServiceId",
                table: "AttributeServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeServices",
                table: "AttributeServices");

            migrationBuilder.RenameTable(
                name: "AttributeServices",
                newName: "AttributeService");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeServices_ServiceId",
                table: "AttributeService",
                newName: "IX_AttributeService_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeServices_AttributeId",
                table: "AttributeService",
                newName: "IX_AttributeService_AttributeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeService",
                table: "AttributeService",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeService_Attributes_AttributeId",
                table: "AttributeService",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeService_Services_ServiceId",
                table: "AttributeService",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
