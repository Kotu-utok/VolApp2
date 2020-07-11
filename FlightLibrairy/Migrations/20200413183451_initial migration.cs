using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightLibrairy.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AeroportDepart = table.Column<string>(nullable: true),
                    AeroportArrivee = table.Column<string>(nullable: true),
                    Prix = table.Column<string>(nullable: true),
                    TotalTravelTime = table.Column<string>(nullable: true),
                    DateDepart = table.Column<DateTime>(nullable: false),
                    DateArrivee = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
