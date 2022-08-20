using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_5175.DAL.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreviousPasswords_AppUsers_AppuserID",
                table: "PreviousPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94358b67-48cb-4700-9c5c-0a662d44ba50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d33e1823-cdbf-4256-883c-ed9a21ef1dbd", "23fb830e-5ba5-4edc-85f6-811a55467094", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d33e1823-cdbf-4256-883c-ed9a21ef1dbd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94358b67-48cb-4700-9c5c-0a662d44ba50", "50e7f3ca-7a8f-49f5-b586-c1a61a8a95e2", "Member", "MEMBER" });

            migrationBuilder.AddForeignKey(
                name: "FK_PreviousPasswords_AppUsers_AppuserID",
                table: "PreviousPasswords",
                column: "AppuserID",
                principalTable: "AppUsers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
