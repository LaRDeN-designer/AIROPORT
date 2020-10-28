using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AIROPORT.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RoutesID",
                table: "Planes",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RoutesID",
                table: "Crew",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<DateTime>(nullable: false),
                    TimeDeparture = table.Column<DateTime>(nullable: false),
                    Departure = table.Column<string>(nullable: true),
                    Arrival = table.Column<string>(nullable: true),
                    Crew_ID = table.Column<long>(nullable: true),
                    Plane_ID = table.Column<long>(nullable: true),
                    FlightTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Planes_RoutesID",
                table: "Planes",
                column: "RoutesID");

            migrationBuilder.CreateIndex(
                name: "IX_Crew_RoutesID",
                table: "Crew",
                column: "RoutesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Crew_Routes_RoutesID",
                table: "Crew",
                column: "RoutesID",
                principalTable: "Routes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planes_Routes_RoutesID",
                table: "Planes",
                column: "RoutesID",
                principalTable: "Routes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crew_Routes_RoutesID",
                table: "Crew");

            migrationBuilder.DropForeignKey(
                name: "FK_Planes_Routes_RoutesID",
                table: "Planes");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Planes_RoutesID",
                table: "Planes");

            migrationBuilder.DropIndex(
                name: "IX_Crew_RoutesID",
                table: "Crew");

            migrationBuilder.DropColumn(
                name: "RoutesID",
                table: "Planes");

            migrationBuilder.DropColumn(
                name: "RoutesID",
                table: "Crew");
        }
    }
}
