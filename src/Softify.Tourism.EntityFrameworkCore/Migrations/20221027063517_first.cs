using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Softify.Tourism.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNo = table.Column<int>(type: "int", nullable: false),
                    NoOfBed = table.Column<int>(type: "int", nullable: false),
                    NoOfExtraBed = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfChild = table.Column<int>(type: "int", nullable: false),
                    NoOfAdult = table.Column<int>(type: "int", nullable: false),
                    TotalAdultAllowed = table.Column<int>(type: "int", nullable: false),
                    TotalChildAllowed = table.Column<int>(type: "int", nullable: false),
                    RoomFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraAdultAllowed = table.Column<int>(type: "int", nullable: false),
                    ExtraChildrenAllowed = table.Column<int>(type: "int", nullable: false),
                    RoomRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Internet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kitchen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageSpoken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LivingArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laundry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodAndDrink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseKeeping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gym = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATMService = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewPapers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Outdoor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accessibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    General = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceptionServices = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SafetyAndSecurity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessFacilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaAndTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conveniences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Policies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHours = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FloorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalNoOfRooms = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomId",
                table: "Services",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
