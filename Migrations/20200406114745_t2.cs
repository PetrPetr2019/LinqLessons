using Microsoft.EntityFrameworkCore.Migrations;

namespace LinqTestLessons.Migrations
{
    public partial class t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_UsePrices_UserPriceid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserPriceid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserPriceid",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserPriceid",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserPriceid",
                table: "Employees",
                column: "UserPriceid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_UsePrices_UserPriceid",
                table: "Employees",
                column: "UserPriceid",
                principalTable: "UsePrices",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
