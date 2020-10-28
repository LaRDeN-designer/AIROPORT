using Microsoft.EntityFrameworkCore.Migrations;

namespace AIROPORT.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HourceFlown = table.Column<string>(nullable: true),
                    CodeStaf1ID = table.Column<long>(nullable: true),
                    CodeStaf2ID = table.Column<long>(nullable: true),
                    CodeStaf3ID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStaff = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    position_ID = table.Column<long>(nullable: true),
                    CrewsID = table.Column<long>(nullable: true),
                    CrewsID1 = table.Column<long>(nullable: true),
                    CrewsID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staffs_Crew_CrewsID",
                        column: x => x.CrewsID,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Crew_CrewsID1",
                        column: x => x.CrewsID1,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Crew_CrewsID2",
                        column: x => x.CrewsID2,
                        principalTable: "Crew",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePosition = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Duties = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffsID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positions_Staffs_StaffsID",
                        column: x => x.StaffsID,
                        principalTable: "Staffs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_StaffsID",
                table: "Positions",
                column: "StaffsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CrewsID",
                table: "Staffs",
                column: "CrewsID");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CrewsID1",
                table: "Staffs",
                column: "CrewsID1");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CrewsID2",
                table: "Staffs",
                column: "CrewsID2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Crew");
        }
    }
}
