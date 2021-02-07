using Microsoft.EntityFrameworkCore.Migrations;

namespace automatedexam.Migrations
{
    public partial class returntooldschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "answer");

            migrationBuilder.DropTable(
                name: "question");

            migrationBuilder.AddColumn<string>(
                name: "question1",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question1AnswerA",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question1AnswerB",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question1AnswerC",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question1AnswerD",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question1CorrectAnswer",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2AnswerA",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2AnswerB",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2AnswerC",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2AnswerD",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question2CorrectAnswer",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3AnswerA",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3AnswerB",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3AnswerC",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3AnswerD",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question3CorrectAnswer",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4AnswerA",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4AnswerB",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4AnswerC",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4AnswerD",
                table: "Exams",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "question4CorrectAnswer",
                table: "Exams",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "question1",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question1AnswerA",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question1AnswerB",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question1AnswerC",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question1AnswerD",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question1CorrectAnswer",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2AnswerA",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2AnswerB",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2AnswerC",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2AnswerD",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question2CorrectAnswer",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3AnswerA",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3AnswerB",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3AnswerC",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3AnswerD",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question3CorrectAnswer",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4AnswerA",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4AnswerB",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4AnswerC",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4AnswerD",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "question4CorrectAnswer",
                table: "Exams");

            migrationBuilder.CreateTable(
                name: "question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExamId = table.Column<int>(type: "INTEGER", nullable: true),
                    correntAnswer = table.Column<string>(type: "TEXT", nullable: true),
                    questionText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_question_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "answer",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    answerText = table.Column<string>(type: "TEXT", nullable: true),
                    questionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_answer_question_questionId",
                        column: x => x.questionId,
                        principalTable: "question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_answer_questionId",
                table: "answer",
                column: "questionId");

            migrationBuilder.CreateIndex(
                name: "IX_question_ExamId",
                table: "question",
                column: "ExamId");
        }
    }
}
