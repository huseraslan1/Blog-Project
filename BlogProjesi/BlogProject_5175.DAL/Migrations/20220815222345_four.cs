using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_5175.DAL.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PreviousPasswords",
                table: "PreviousPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c1d707-2e50-445e-b618-c26f1f2c9488");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "PreviousPasswords");

            migrationBuilder.AddColumn<string>(
                name: "PPassword",
                table: "PreviousPasswords",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreviousPasswords",
                table: "PreviousPasswords",
                columns: new[] { "AppuserID", "PPassword" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94358b67-48cb-4700-9c5c-0a662d44ba50", "50e7f3ca-7a8f-49f5-b586-c1a61a8a95e2", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PreviousPasswords",
                table: "PreviousPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94358b67-48cb-4700-9c5c-0a662d44ba50");

            migrationBuilder.DropColumn(
                name: "PPassword",
                table: "PreviousPasswords");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "PreviousPasswords",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreviousPasswords",
                table: "PreviousPasswords",
                columns: new[] { "AppuserID", "Password" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c1d707-2e50-445e-b618-c26f1f2c9488", "52593f04-d67d-40a9-9841-3c01932803f1", "Member", "MEMBER" });
        }
    }
}
