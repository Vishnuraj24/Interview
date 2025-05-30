using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class secondmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Age", "Department", "EmployeeName", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "IT", "Employee1", 200.0 },
                    { 2, 2, "HR", "Employee2", 1000.0 },
                    { 3, 3, "IT", "Employee3", 600.0 },
                    { 4, 4, "HR", "Employee4", 2000.0 },
                    { 5, 5, "IT", "Employee5", 1000.0 },
                    { 6, 6, "HR", "Employee6", 3000.0 },
                    { 7, 7, "IT", "Employee7", 1400.0 },
                    { 8, 8, "HR", "Employee8", 4000.0 },
                    { 9, 9, "IT", "Employee9", 1800.0 },
                    { 10, 10, "HR", "Employee10", 5000.0 },
                    { 11, 11, "IT", "Employee11", 2200.0 },
                    { 12, 12, "HR", "Employee12", 6000.0 },
                    { 13, 13, "IT", "Employee13", 2600.0 },
                    { 14, 14, "HR", "Employee14", 7000.0 },
                    { 15, 15, "IT", "Employee15", 3000.0 },
                    { 16, 16, "HR", "Employee16", 8000.0 },
                    { 17, 17, "IT", "Employee17", 3400.0 },
                    { 18, 18, "HR", "Employee18", 9000.0 },
                    { 19, 19, "IT", "Employee19", 3800.0 },
                    { 20, 20, "HR", "Employee20", 10000.0 },
                    { 21, 21, "IT", "Employee21", 4200.0 },
                    { 22, 22, "HR", "Employee22", 11000.0 },
                    { 23, 23, "IT", "Employee23", 4600.0 },
                    { 24, 24, "HR", "Employee24", 12000.0 },
                    { 25, 25, "IT", "Employee25", 5000.0 },
                    { 26, 26, "HR", "Employee26", 13000.0 },
                    { 27, 27, "IT", "Employee27", 5400.0 },
                    { 28, 28, "HR", "Employee28", 14000.0 },
                    { 29, 29, "IT", "Employee29", 5800.0 },
                    { 30, 30, "HR", "Employee30", 15000.0 },
                    { 31, 31, "IT", "Employee31", 6200.0 },
                    { 32, 32, "HR", "Employee32", 16000.0 },
                    { 33, 33, "IT", "Employee33", 6600.0 },
                    { 34, 34, "HR", "Employee34", 17000.0 },
                    { 35, 35, "IT", "Employee35", 7000.0 },
                    { 36, 36, "HR", "Employee36", 18000.0 },
                    { 37, 37, "IT", "Employee37", 7400.0 },
                    { 38, 38, "HR", "Employee38", 19000.0 },
                    { 39, 39, "IT", "Employee39", 7800.0 },
                    { 40, 40, "HR", "Employee40", 20000.0 },
                    { 41, 41, "IT", "Employee41", 8200.0 },
                    { 42, 42, "HR", "Employee42", 21000.0 },
                    { 43, 43, "IT", "Employee43", 8600.0 },
                    { 44, 44, "HR", "Employee44", 22000.0 },
                    { 45, 45, "IT", "Employee45", 9000.0 },
                    { 46, 46, "HR", "Employee46", 23000.0 },
                    { 47, 47, "IT", "Employee47", 9400.0 },
                    { 48, 48, "HR", "Employee48", 24000.0 },
                    { 49, 49, "IT", "Employee49", 9800.0 },
                    { 50, 50, "HR", "Employee50", 25000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 50);
        }
    }
}
