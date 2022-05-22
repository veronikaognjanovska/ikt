using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Repository.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4db01a7e-7546-4afd-96f2-55d9c328089d", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4db01a7e-7546-4afd-96f2-55d9c328089d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2eeb08b9-b24f-4246-ae07-c68fc6e8c84a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a79f3539-b1c2-426f-a1e4-80bf506aeddf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e3e18a52-1777-4003-9a81-3ef86b62483e", 0, "555cccc0-67ee-4cad-aebc-dbb2f51a260e", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEM2x8vLg5YyiY1kmm82FE/BSZFY1pzLLV2Egy6N5w1U/6RhDyvUbpsXqTw0j//MAlA==", null, false, "fe8a3195-3632-4a18-bc3d-1deed5713ae2", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e3e18a52-1777-4003-9a81-3ef86b62483e", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e3e18a52-1777-4003-9a81-3ef86b62483e", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3e18a52-1777-4003-9a81-3ef86b62483e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c3a6daf4-db5c-4c5c-a736-50851160c601");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3be3b846-1665-4123-81d9-7f6d4727c18c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4db01a7e-7546-4afd-96f2-55d9c328089d", 0, "206e5657-b676-44c9-b070-7745b000d42c", "admin@test.com", true, false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEOGkkKqPhO2YxpZgo+ybfxrhDOon3Hk0Cb9W+pdUgI/lSuuomPHbmJV+eI89eUlCLw==", null, false, "b6f20453-670f-4259-94de-005485150ba2", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4db01a7e-7546-4afd-96f2-55d9c328089d", "1" });
        }
    }
}
