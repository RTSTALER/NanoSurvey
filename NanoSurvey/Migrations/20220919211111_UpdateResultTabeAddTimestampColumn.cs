using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NanoSurvey.Migrations
{
    public partial class UpdateResultTabeAddTimestampColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Timestamp",
                table: "Result",
                type: "text",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Result");
        }
    }
}
