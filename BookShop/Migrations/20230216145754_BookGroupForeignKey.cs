using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShop.Migrations
{
    public partial class BookGroupForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Books_GroupId",
                table: "Books",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Groups_GroupId",
                table: "Books",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Groups_GroupId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GroupId",
                table: "Books");
        }
    }
}
