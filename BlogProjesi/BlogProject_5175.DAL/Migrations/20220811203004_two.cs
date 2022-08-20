using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject_5175.DAL.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10e85395-bf8c-429b-8733-a5d3846a6fe9");

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => new { x.ArticleID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccd51eb5-ab41-475a-b490-456f9c7e8abc", "340b4c0c-1c82-4ca7-963b-a7eedfc79ec0", "Member", "MEMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategories_CategoryID",
                table: "ArticleCategories",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccd51eb5-ab41-475a-b490-456f9c7e8abc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "10e85395-bf8c-429b-8733-a5d3846a6fe9", "f205ea74-7e02-4e1f-a525-4729f81e4b1a", "Member", "MEMBER" });
        }
    }
}
