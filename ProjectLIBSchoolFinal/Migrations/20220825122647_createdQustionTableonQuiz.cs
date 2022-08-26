using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectLIBSchoolFinal.Migrations
{
    public partial class createdQustionTableonQuiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
          migrationBuilder.DropColumn(
                name: "Questions",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "A",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "B",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correct",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "D",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "E",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuestionName",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizInfoId",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizInfoId",
                table: "Questions",
                column: "QuizInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuizInfos_QuizInfoId",
                table: "Questions",
                column: "QuizInfoId",
                principalTable: "QuizInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuizInfos_QuizInfoId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuizInfoId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "A",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "B",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "C",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Correct",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "D",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "E",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionName",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizInfoId",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }
    }
}
