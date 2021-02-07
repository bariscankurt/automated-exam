using Microsoft.EntityFrameworkCore.Migrations;

namespace automatedexam.Migrations
{
    public partial class ExamTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    examArticle = table.Column<string>(type: "TEXT", nullable: true),
                    question1 = table.Column<string>(type: "TEXT", nullable: true),
                    question2 = table.Column<string>(type: "TEXT", nullable: true),
                    question3 = table.Column<string>(type: "TEXT", nullable: true),
                    question4 = table.Column<string>(type: "TEXT", nullable: true),
                    question1AnswerA = table.Column<string>(type: "TEXT", nullable: true),
                    question1AnswerB = table.Column<string>(type: "TEXT", nullable: true),
                    question1AnswerC = table.Column<string>(type: "TEXT", nullable: true),
                    question1AnswerD = table.Column<string>(type: "TEXT", nullable: true),
                    question2AnswerA = table.Column<string>(type: "TEXT", nullable: true),
                    question2AnswerB = table.Column<string>(type: "TEXT", nullable: true),
                    question2AnswerC = table.Column<string>(type: "TEXT", nullable: true),
                    question2AnswerD = table.Column<string>(type: "TEXT", nullable: true),
                    question3AnswerA = table.Column<string>(type: "TEXT", nullable: true),
                    question3AnswerB = table.Column<string>(type: "TEXT", nullable: true),
                    question3AnswerC = table.Column<string>(type: "TEXT", nullable: true),
                    question3AnswerD = table.Column<string>(type: "TEXT", nullable: true),
                    question4AnswerA = table.Column<string>(type: "TEXT", nullable: true),
                    question4AnswerB = table.Column<string>(type: "TEXT", nullable: true),
                    question4AnswerC = table.Column<string>(type: "TEXT", nullable: true),
                    question4AnswerD = table.Column<string>(type: "TEXT", nullable: true),
                    question1CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    question2CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    question3CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    question4CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
