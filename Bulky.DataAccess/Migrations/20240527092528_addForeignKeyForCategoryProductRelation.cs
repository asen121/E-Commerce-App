using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCategoryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Prodcuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Prodcuts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Prodcuts_CategoryId",
                table: "Prodcuts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodcuts_Categories_CategoryId",
                table: "Prodcuts");

            migrationBuilder.DropIndex(
                name: "IX_Prodcuts_CategoryId",
                table: "Prodcuts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Prodcuts");
        }
    }
}
