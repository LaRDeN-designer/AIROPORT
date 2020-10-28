using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AIROPORT.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PlanesID",
                table: "Staffs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneMark = table.Column<string>(nullable: true),
                    CapacityPassengers = table.Column<int>(nullable: false),
                    Tonnage = table.Column<int>(nullable: false),
                    TypePlane_ID = table.Column<long>(nullable: true),
                    TechnicalParameters = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    HourceFlown = table.Column<int>(nullable: false),
                    DatelastRepair = table.Column<DateTime>(nullable: false),
                    Staff_ID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypePlanes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePlane = table.Column<string>(nullable: true),
                    DestinationPlane = table.Column<string>(nullable: true),
                    limitationsPlane = table.Column<string>(nullable: true),
                    PlanesID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePlanes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypePlanes_Planes_PlanesID",
                        column: x => x.PlanesID,
                        principalTable: "Planes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_PlanesID",
                table: "Staffs",
                column: "PlanesID");

            migrationBuilder.CreateIndex(
                name: "IX_TypePlanes_PlanesID",
                table: "TypePlanes",
                column: "PlanesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Planes_PlanesID",
                table: "Staffs",
                column: "PlanesID",
                principalTable: "Planes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Planes_PlanesID",
                table: "Staffs");

            migrationBuilder.DropTable(
                name: "TypePlanes");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_PlanesID",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "PlanesID",
                table: "Staffs");
        }
    }
}
