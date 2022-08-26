using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectLIBSchoolFinal.Migrations
{
    public partial class createdcountfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalCorrect",
                table: "onlineExams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCorrect",
                table: "onlineExams");
        }
    }
}
