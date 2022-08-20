using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_5175.DAL.Migrations
{
    public partial class BlogProjectContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d01b7380-104e-4a00-9501-b704c0e24ba4");

            migrationBuilder.AddColumn<int>(
                name: "ReadCount",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReadTime",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10e85395-bf8c-429b-8733-a5d3846a6fe9", "f205ea74-7e02-4e1f-a525-4729f81e4b1a", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e85395-bf8c-429b-8733-a5d3846a6fe9");

            migrationBuilder.DropColumn(
                name: "ReadCount",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ReadTime",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d01b7380-104e-4a00-9501-b704c0e24ba4", "d85bdeac-29bd-4f73-ae43-8b5ff9dba06b", "Member", "MEMBER" });
        }
    }
}
