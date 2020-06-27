using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDevSchoolApi.Migrations
{
    public partial class innitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SchoolName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevPrograms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProgramName = table.Column<string>(nullable: false),
                    ClosestStartDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SchoolId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevPrograms_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevPrograms_SchoolId",
                table: "DevPrograms",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevPrograms");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
