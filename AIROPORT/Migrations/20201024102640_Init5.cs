using Microsoft.EntityFrameworkCore.Migrations;

namespace AIROPORT.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TicketsID",
                table: "Routes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePassenger = table.Column<string>(nullable: true),
                    PassportDataPassengers = table.Column<string>(nullable: true),
                    Airoport = table.Column<string>(nullable: true),
                    Route_ID = table.Column<long>(nullable: true),
                    CostTiket = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Routes_TicketsID",
                table: "Routes",
                column: "TicketsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Tickets_TicketsID",
                table: "Routes",
                column: "TicketsID",
                principalTable: "Tickets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Tickets_TicketsID",
                table: "Routes");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Routes_TicketsID",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "TicketsID",
                table: "Routes");
        }
    }
}
