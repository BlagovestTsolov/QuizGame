using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class TriviaAndCategoryTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trivias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Trivia Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trivias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trivias_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Trivias_CategoryId",
                table: "Trivias",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trivias");

            migrationBuilder.DropTable(
                name: "Categories");

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
        }
    }
}
