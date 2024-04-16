using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class TriviaAndCategorySeedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e102f310-99fa-44a5-bb89-ac05dd999235", "AQAAAAEAACcQAAAAEBeE5Fhi5Na6peq+rQwpxTvP/8iFINEEPkUhX4Ofqx6Cnwiay8G46UnjH1KrKHJnIQ==", "077f0076-d06f-4db4-b345-ae3cb6259404" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a73a33-ad9b-4f9d-9789-43bf487eeeab", "AQAAAAEAACcQAAAAELHHAfh67nnMH0iOqaUxkZBirn/XQf33jFrjG+4z2diBBgDWtN01NYsaUeulTZyjfw==", "bbb50632-7c6d-49a9-a5ae-6bd9801314ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ee91401-901a-4979-9cdf-76329bce2737", "AQAAAAEAACcQAAAAEIaS38hqnzhlqjOBtWlV2GPjcLF+XMTzEf7z2rhhUAIciZGlvCrqU0YO5+v5Wnx4EA==", "9531d044-be0d-46b3-aad2-fb5f4c1ac862" });
        }
    }
}
