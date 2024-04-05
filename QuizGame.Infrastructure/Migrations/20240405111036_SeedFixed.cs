using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class SeedFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c52c645d-8573-4a49-b418-6a80194be28a", "author@mail.com", "author@mail.com", "author@mail.com", "AQAAAAEAACcQAAAAEHml5KsWeSYMdQN5eN6es8U2uyGzGLcG3cmjMKyigGWkmzKWfkwPYK6j7kIdbdtMoQ==", "79d42809-a5d4-413c-b5b2-e948bc17b7cc", "author@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc328a40-4eb9-4a31-8d35-75151cac1b77", "AQAAAAEAACcQAAAAEEhJl+f+rPp2u5PosY/7rxlkvVdT1YibhomXG5kL02m+dzNBEw+bCxIzKphA/sNimg==", "c6f459cc-3351-41ab-b701-8304805d34aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17a5c99d-84d0-45c5-b853-b22649c40ba2", "AQAAAAEAACcQAAAAEPFqGzgJdsPIOUbu9Poh2Hq9ma3DRRAwJY5RP8DnMNIHmJyDqp/U/RZcTDExt0K8zg==", "2a5aaacb-320b-4797-8ac1-3182e25a4e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7ab1bd4b-e423-4812-90ad-bcc70547f176", "agent@mail.com", "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEDsT5InbaxM62//c4Y0hlsJuCExgaYf5B8vGFU1U6SAkbh32DEzGe8kIiGktz/jNDg==", "96f583e4-279d-4f73-b4f5-41c07f419649", "agent@mail.com" });
        }
    }
}
