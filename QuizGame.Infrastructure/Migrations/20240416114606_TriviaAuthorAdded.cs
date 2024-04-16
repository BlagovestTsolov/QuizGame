using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class TriviaAuthorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Trivias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Author Identifier");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Trivias",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                comment: "Comment");

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

            migrationBuilder.CreateIndex(
                name: "IX_Trivias_AuthorId",
                table: "Trivias",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trivias_Authors_AuthorId",
                table: "Trivias",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trivias_Authors_AuthorId",
                table: "Trivias");

            migrationBuilder.DropIndex(
                name: "IX_Trivias_AuthorId",
                table: "Trivias");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Trivias");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Trivias");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147ab35f-3390-4120-bba8-e167d34a3489", "AQAAAAEAACcQAAAAELqNCZTsGQQ5MY5d3iliKGv6mejTfkkcMGKUdIh2uWKgELpCdfrSeKJZJwNXRwMKHA==", "57e5782e-217f-41a2-a7e6-d01879d3b44b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae85ccce-46eb-4187-bd35-fec3a1363df6", "AQAAAAEAACcQAAAAEMAMFanBqBwzflZTBJzcwNBdkde/dsfWUpEciolWCVS/RMWS/dV66T9oDXaXsks9rQ==", "8115f374-73c8-48cc-918e-985e4db78740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09259d5d-7816-4bf7-a9d1-4026de4747bc", "AQAAAAEAACcQAAAAEKgSgFsWhTPIvo9+muX5NNtE/FSifwCCLYWRfKDByML6BU1iuyeoIBgACgSSent3Nw==", "cdf393af-c19c-4714-b427-69ee0d4cdae7" });
        }
    }
}
