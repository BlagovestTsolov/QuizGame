using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class QuizAnswerPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "Quizzes",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                comment: "Answer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce26e4b8-5fe8-4310-9e00-1806dc77929e", "AQAAAAEAACcQAAAAENLF7okylX1W1y3w9x8EuQ+RFq3HaBG0TbQcrxQLvxhD3fIVxJImqF/4LRFa1+Abhw==", "e9313d50-5099-45be-9163-acb632d6472e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6393ec4-b86a-46ce-a9f7-56e20fb8ddc5", "AQAAAAEAACcQAAAAEGQ9hTz7w4Sj/Kn9XVFFASz70Ea8+WscMlxj9gnfdS5H+BHTsms9/HUo5jUesisNIQ==", "abff7c86-a53c-4754-a9df-96553ca8644c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8b2a928-089f-45b3-9819-74c9a9ab079a", "AQAAAAEAACcQAAAAEOhj+i0vrLKGeztjsnwMSq5H0Gg7f6+9pt1NvtGvK0j84s7pl5n0XZsKT0RzHLmICg==", "91368525-d99a-4917-9f52-80e295488e5c" });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Answer",
                value: "Те са създатели на славянската писменост, преводачи на богослужебни книги, проповедници на християнството и основоположници на българската литература.");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Answer",
                value: "Фотосинтезата е процес, при който слънчевата светлина се превръща в химическа енергия, съхранена в глюкоза. Този процес се осъществява от фотосинтезиращи организми, като растения, водорасли и някои бактерии.");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Answer",
                value: "Трите основни периода в развитието на българската литература са: Старобългарска литература (IX-XVIII век), Възрожденска литература (XVIII-XIX век) и Съвременна българска литература (XIX-XXI век)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Quizzes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d663838f-3ae0-455a-8ced-ebd0aea59e78", "AQAAAAEAACcQAAAAEOpfRc5FaJ3Y0tcHvTOdhNRl+0xO7NNtG9ar9cbEEAWyiTjE/J+A8oN4a8ONww3OCg==", "f5cbaba0-fa30-4287-ad0f-4dae9089e9d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d36a6f7-7050-439a-ac92-21c87ba64a11", "AQAAAAEAACcQAAAAEJ8eWm5c6W7DbAs810fFMxpNPi2Oe1goDOjTr+JhAuyoZA5iJvn1qonPSmXaR1P3IA==", "6afc6cc1-b91e-430e-939f-6ec566fc8abf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52c645d-8573-4a49-b418-6a80194be28a", "AQAAAAEAACcQAAAAEHml5KsWeSYMdQN5eN6es8U2uyGzGLcG3cmjMKyigGWkmzKWfkwPYK6j7kIdbdtMoQ==", "79d42809-a5d4-413c-b5b2-e948bc17b7cc" });
        }
    }
}
