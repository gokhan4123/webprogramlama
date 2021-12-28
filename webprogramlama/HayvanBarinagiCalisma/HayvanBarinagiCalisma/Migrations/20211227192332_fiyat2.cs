using Microsoft.EntityFrameworkCore.Migrations;

namespace Ciftlik.Migrations
{
    public partial class fiyat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "46dce693-34ba-4219-be0c-07a61daed236");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7bded35a-e9a8-4249-b70d-3a41fbb1da4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7953a3b-a013-49f7-aefd-c62d553a7c9b", "AQAAAAEAACcQAAAAEP0VKl5JWeyh9UJZx9ODslEzLRSCIS8+zeRtnx7DqJdYd+FvSxFlrRwTMwNsWPE5tg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a5f41a8-c000-4acd-8a14-f850471cf9b3", "AQAAAAEAACcQAAAAEK0Cd3qXiDPCk+YPOx6tR4A1AnjO+BsZsrRpurbIWTEoc01NngmULYFUWsZUPNS2Fw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9fe9e449-d482-4459-af2c-e69e1f2d1216");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5573cd3d-8ddf-4985-99e3-0f5dd12c3c44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3045c3c-eb73-4c6e-a70f-92c8fd978d1c", "AQAAAAEAACcQAAAAEIrDAp1bu2ikd+1X/NIIbgDPz6RKy8XsblDpUyWd56vqybAWoA8qUkQRY31RNKbvfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e576",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a767e44a-ffdb-4322-8816-77834e704251", "AQAAAAEAACcQAAAAEDHGouedLnblef2t49+tUIbhtHe08hY3CVNvFqwsov+2r+qbAa8WyuVdDx/RMeTsPw==" });
        }
    }
}
