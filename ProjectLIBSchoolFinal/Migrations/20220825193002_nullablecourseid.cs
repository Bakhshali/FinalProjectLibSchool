using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectLIBSchoolFinal.Migrations
{
    public partial class nullablecourseid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Courses_CourseId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "OrderItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Courses_CourseId",
                table: "OrderItems",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Courses_CourseId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Courses_CourseId",
                table: "OrderItems",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
