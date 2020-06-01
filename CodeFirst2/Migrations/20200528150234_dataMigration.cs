using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst2.Migrations
{
    public partial class dataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 1, 100000000000000.0, "Midland, MI", "R&D", "Science" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 2, 200000000000000.0, "Dhaka, Bangladesh", "HR", "Administrative" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Budget", "Location", "Name", "Type" },
                values: new object[] { 3, 53.0, "Party City, USA", "Fun Department", "Administrative" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "venkman@ghostbusters.co", "Peter", "Venkman" },
                    { 2, 2, "ray@ghostbusters.co", "Ray", "Stantz" },
                    { 4, 2, "slimer@ghosts.co", "Slimer", null },
                    { 3, 3, "egon@ghostbusters.co", "Egon", "Spengler" },
                    { 5, 3, "dana@nyphil.co", "Dana", "Barrett" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
