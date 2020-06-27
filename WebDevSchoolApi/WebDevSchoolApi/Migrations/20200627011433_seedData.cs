using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDevSchoolApi.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "SchoolName" },
                values: new object[] { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "555 Seymour St, Vancouver, BC V6B 3H6", "BCIT" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "SchoolName" },
                values: new object[] { new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"), "100 W 49th Ave, Vancouver, BC V5Y 2Z6", "Langara" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "SchoolName" },
                values: new object[] { new Guid("2902b665-1190-4c70-9915-b9c2d7680450"), "401 W Georgia St, Vancouver, BC V6B 5A1", "Lighthouse Labs" });

            migrationBuilder.InsertData(
                table: "DevPrograms",
                columns: new[] { "Id", "ClosestStartDate", "Description", "ProgramName", "SchoolId" },
                values: new object[] { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Software System Developer", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35") });

            migrationBuilder.InsertData(
                table: "DevPrograms",
                columns: new[] { "Id", "ClosestStartDate", "Description", "ProgramName", "SchoolId" },
                values: new object[] { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Full Stack Web Development", new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96") });

            migrationBuilder.InsertData(
                table: "DevPrograms",
                columns: new[] { "Id", "ClosestStartDate", "Description", "ProgramName", "SchoolId" },
                values: new object[] { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Web Development Bootcamp", new Guid("2902b665-1190-4c70-9915-b9c2d7680450") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DevPrograms",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"));

            migrationBuilder.DeleteData(
                table: "DevPrograms",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"));

            migrationBuilder.DeleteData(
                table: "DevPrograms",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("2902b665-1190-4c70-9915-b9c2d7680450"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"));
        }
    }
}
