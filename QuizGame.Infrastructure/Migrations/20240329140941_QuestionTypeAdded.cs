using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class QuestionTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Quizzes");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Quizzes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "Question",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Question");

            migrationBuilder.AddColumn<int>(
                name: "QuestionTypeId",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Question Type Identifier");

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Quiz type Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Quiz type name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_QuestionTypeId",
                table: "Quizzes",
                column: "QuestionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_QuestionTypeId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "QuestionTypeId",
                table: "Quizzes");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Quizzes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Question",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "Question");

            migrationBuilder.AddColumn<int>(
                name: "QuestionType",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Question Type");
        }
    }
}
