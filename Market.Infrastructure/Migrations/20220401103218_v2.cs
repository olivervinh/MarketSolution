using Microsoft.EntityFrameworkCore.Migrations;

namespace Market.Infrastructure.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageProducts_Products_FkProductId",
                table: "ImageProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageProducts",
                table: "ImageProducts");

            migrationBuilder.RenameTable(
                name: "ImageProducts",
                newName: "ProductImages");

            migrationBuilder.RenameIndex(
                name: "IX_ImageProducts_FkProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_FkProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_FkProductId",
                table: "ProductImages",
                column: "FkProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_FkProductId",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ImageProducts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_FkProductId",
                table: "ImageProducts",
                newName: "IX_ImageProducts_FkProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageProducts",
                table: "ImageProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageProducts_Products_FkProductId",
                table: "ImageProducts",
                column: "FkProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
