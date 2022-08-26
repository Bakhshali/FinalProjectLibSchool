using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectLIBSchoolFinal.Migrations
{
    public partial class createOnlineExamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "onlineExams",
                columns: table => new
                {
                    Qid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    option1 = table.Column<string>(nullable: true),
                    option2 = table.Column<string>(nullable: true),
                    option3 = table.Column<string>(nullable: true),
                    option4 = table.Column<string>(nullable: true),
                    Correct = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_onlineExams", x => x.Qid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "onlineExams");
        }
    }
}
