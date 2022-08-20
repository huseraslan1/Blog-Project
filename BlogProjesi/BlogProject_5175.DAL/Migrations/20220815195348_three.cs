using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_5175.DAL.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccd51eb5-ab41-475a-b490-456f9c7e8abc");

            migrationBuilder.CreateTable(
                name: "PreviousPasswords",
                columns: table => new
                {
                    AppuserID = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousPasswords", x => new { x.AppuserID, x.Password });
                    table.ForeignKey(
                        name: "FK_PreviousPasswords_AppUsers_AppuserID",
                        column: x => x.AppuserID,
                        principalTable: "AppUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57c1d707-2e50-445e-b618-c26f1f2c9488", "52593f04-d67d-40a9-9841-3c01932803f1", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreviousPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c1d707-2e50-445e-b618-c26f1f2c9488");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccd51eb5-ab41-475a-b490-456f9c7e8abc", "340b4c0c-1c82-4ca7-963b-a7eedfc79ec0", "Member", "MEMBER" });
        }
    }
}
