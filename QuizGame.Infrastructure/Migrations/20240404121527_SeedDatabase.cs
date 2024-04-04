using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Authors_AuthorId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ef1d854-a356-48bd-97d5-e892207d5f5e", 0, "dc328a40-4eb9-4a31-8d35-75151cac1b77", "admin@mail.com", false, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEEhJl+f+rPp2u5PosY/7rxlkvVdT1YibhomXG5kL02m+dzNBEw+bCxIzKphA/sNimg==", null, false, "c6f459cc-3351-41ab-b701-8304805d34aa", false, "admin@mail.com" },
                    { "73a2cef5-9df0-4cbd-9459-67179923fbb1", 0, "17a5c99d-84d0-45c5-b853-b22649c40ba2", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEPFqGzgJdsPIOUbu9Poh2Hq9ma3DRRAwJY5RP8DnMNIHmJyDqp/U/RZcTDExt0K8zg==", null, false, "2a5aaacb-320b-4797-8ac1-3182e25a4e8f", false, "guest@mail.com" },
                    { "fd59e0b6-59ae-4ff9-a1cf-029508048fe5", 0, "7ab1bd4b-e423-4812-90ad-bcc70547f176", "agent@mail.com", false, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEDsT5InbaxM62//c4Y0hlsJuCExgaYf5B8vGFU1U6SAkbh32DEzGe8kIiGktz/jNDg==", null, false, "96f583e4-279d-4f73-b4f5-41c07f419649", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "History" },
                    { 2, "Biology" },
                    { 3, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, "fd59e0b6-59ae-4ff9-a1cf-029508048fe5" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 2, "0ef1d854-a356-48bd-97d5-e892207d5f5e" });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AuthorId", "Question", "QuestionTypeId" },
                values: new object[] { 1, 1, "Каква е ролята на Кирил и Методий за развитието на българската култура?", 1 });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AuthorId", "Question", "QuestionTypeId" },
                values: new object[] { 2, 1, "Какъв е процесът на фотосинтеза и каква е неговата роля за живите организми?", 2 });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "AuthorId", "Question", "QuestionTypeId" },
                values: new object[] { 3, 1, "Кои са трите основни периода в развитието на българската литература?", 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Authors_AuthorId",
                table: "Quizzes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Authors_AuthorId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Authors_AuthorId",
                table: "Quizzes",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_QuestionTypes_QuestionTypeId",
                table: "Quizzes",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
