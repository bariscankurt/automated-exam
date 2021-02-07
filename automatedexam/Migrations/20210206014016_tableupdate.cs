using Microsoft.EntityFrameworkCore.Migrations;

namespace automatedexam.Migrations
{
    public partial class tableupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "examTitle",
                table: "Exams",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examTitle",
                table: "Exams");
        }
    }
}
