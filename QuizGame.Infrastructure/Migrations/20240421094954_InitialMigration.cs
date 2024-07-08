using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizGame.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef1d854-a356-48bd-97d5-e892207d5f5e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae8310d8-4bf1-4786-8e55-fec93d99e9e1", "AQAAAAEAACcQAAAAEIZcN0zLRN8AebdXzVqQPfVWm6LejjhtRt6o++hiSqt//cr0cYmEth7ex0R7nxqO5A==", "863760d4-fafc-481a-9b44-d93e4c0a890f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a2cef5-9df0-4cbd-9459-67179923fbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0735c4d0-cbb2-4dc2-a4db-7461fa6e57c7", "AQAAAAEAACcQAAAAEFJkhcZzbH1SOqBSjbbiVzpm2DWqAzoP75sWcXD9CGOrTvNV1Wzso+qG4bB6fbeBZQ==", "f07e2d73-37cc-45bd-90ce-26b8279d89c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd59e0b6-59ae-4ff9-a1cf-029508048fe5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eda2e77-d070-43fe-9ded-ebbd37c8b486", "AQAAAAEAACcQAAAAEFVz+haDXE37KodVxtleEIGOIMoTFxnudRLBENMVDLDjVGcmMP6RWg3LjE71fIMzVg==", "d1bb49a2-c2d4-40de-a908-215df840a46a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
