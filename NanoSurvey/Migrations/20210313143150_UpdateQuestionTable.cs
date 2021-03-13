using Microsoft.EntityFrameworkCore.Migrations;

namespace NanoSurvey.Migrations
{
    public partial class UpdateQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionNumber",
                table: "Question",
                type: "integer",
                nullable: false
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionNumber",
                table: "Question");
        }
    }
}
