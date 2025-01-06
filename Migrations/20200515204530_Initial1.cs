using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionConcoursCore.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "ID", "Password", "Username" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Filieres",
                columns: new[] { "ID", "Nom" },
                values: new object[,]
                {
                    { 1, "Informatique" },
                    { 2, "GTR" },
                    { 3, "Industriel" },
                    { 4, "GPMC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Filieres",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
