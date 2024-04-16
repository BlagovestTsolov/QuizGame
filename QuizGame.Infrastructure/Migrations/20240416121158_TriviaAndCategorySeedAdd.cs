using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class TriviaAndCategorySeedAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdde2490-f4a1-4054-b7c6-57f587f51a1d", "AQAAAAEAACcQAAAAEDarBXF56p+EsUUUBp6LHG92RbLFUICP+PpBH2onhxr3khX1tiS79EAP4hlKnNd+Ug==", "21b32832-864e-483d-a1ee-3eaaf1f05e62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceb8b1ef-bf3b-4511-949b-76bd8c7d8b9d", "AQAAAAEAACcQAAAAENCuY+xf8XVYVk3qKamJSXiWmc53ZZc0acB0opJnGysw0SXmHeJ7IzPk8TCekJkcCQ==", "f1adb400-d30b-4ab5-b6be-b6da71156d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56903955-7f80-478e-8bbc-bdb550d56a8d", "AQAAAAEAACcQAAAAEBFSq6KfJmOhdFi6Vb16D91pAabtSSREnxtcZOoBRo7hVVRCtxNYDXwEopC2KH5Fzw==", "b110223d-8a5b-4465-830a-6195568b625d" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tech" },
                    { 2, "Politics" },
                    { 3, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Comment" },
                values: new object[] { 1, 1, 1, "Няколко български компании разработват AI и ML решения за различни индустрии, като здравеопазване, финанси, селско стопанство и производство." });

            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Comment" },
                values: new object[] { 2, 1, 2, "Българската политика е сравнително динамична и многопартийна, с множество политически партии, които се борят за влияние." });

            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Comment" },
                values: new object[] { 3, 1, 3, "Григор Димитров: Най-успешният български тенисист, класирал се до №3 в световната ранглиста за мъже. Печелил е ATP Finals през 2018 г. и е участвал на полуфинал на Уимбълдън през 2014 г." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4037c23-92d2-490d-af1c-9587b9f84a45", "AQAAAAEAACcQAAAAEPVZqONtpxfBpk2aSl9z0mseUKOt93LOmnJdpLDIbPXOunX+bdEJbki4qZ3+JsfDkg==", "b8f81576-0d9a-47f0-ac6e-e56bf505413c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afee9413-73a7-4c66-b602-042965f3c86d", "AQAAAAEAACcQAAAAEJGBjwPXU+JK6n2KMxSz1SpsOY2iOhv4b37MiULahtI9Yj3ChjBraXIFgmf5aDe6GA==", "8189a4e6-2b69-4803-b316-a8e4584483e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2282a546-4572-4fb4-b2fa-03fb4986ca25", "AQAAAAEAACcQAAAAEN/BvUt4PNk7oc+Xd9+n5rDVdrPAVPPkGiPjHBHdE0SzDDWfxyxeE1Fl+bVWA2nlpg==", "5c5ba070-eae3-4f78-93a4-c75e8bff2bb2" });
        }
    }
}
