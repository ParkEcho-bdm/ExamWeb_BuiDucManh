using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_BuiDucManh.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                   table: "phims",
                   columns: new[] { "Id", "TuaDe", "DienVien", "TrongNuoc", "GiaVe","ThoiLuong" },
                   values: new object[,]
                   {
                    { 1, "A", "B", "", 100,10 },
                    { 2, "b", "a", "", 100,101 },
                    { 3, "c", "B", "", 1000,103 },
                    { 4, "d", "B", "", 100,103 },
                    { 5,"A", "B", "", 100,104 },
                    { 6, "A", "B", "", 100,105 },
                   });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "phims",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
