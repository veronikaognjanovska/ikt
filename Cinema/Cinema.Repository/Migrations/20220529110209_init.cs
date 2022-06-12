using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c04d42d5-5551-42f8-b768-ea2774c94bc1", "1" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("bdd2ac23-0353-489d-9201-0f1649e5f5c1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c04d42d5-5551-42f8-b768-ea2774c94bc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "22febb29-d942-4402-8b5a-9c54543c784d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2b7af7a8-d2fa-44f7-967a-5d53bc25ca7f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aec07e10-aad9-4d81-a07c-3c9a0b82bc34", 0, "1794c48f-a7e4-4395-9791-112dd67b7642", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEMqCcg8Y6RuNun5/NPAHx2V8IXSZ5Iv+qh/H/CHX5HMCnf+EODAY3gUJV82fxFU//A==", null, true, "92f36ee8-838c-4434-92de-5454627f24cb", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "aec07e10-aad9-4d81-a07c-3c9a0b82bc34", "1" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("750cb038-a20f-46de-ab61-2d5797a3eae4"), "aec07e10-aad9-4d81-a07c-3c9a0b82bc34" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aec07e10-aad9-4d81-a07c-3c9a0b82bc34", "1" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("750cb038-a20f-46de-ab61-2d5797a3eae4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aec07e10-aad9-4d81-a07c-3c9a0b82bc34");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bd8ee82d-9b82-4af2-b439-e4bcb8e14ff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5cfb2909-e020-4e86-9774-c132beec1e66");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c04d42d5-5551-42f8-b768-ea2774c94bc1", 0, "f4066056-ef1b-4887-a8d4-ce5d154c609d", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEIA0M3B6/i6YURQtD7sDu6hdy2sWeO7VD/SV0gvkcfWAASDidCYQpo0cjn0srt6PWg==", null, true, "7f5ed15b-db8d-4cf7-bbef-bd764c51c8b9", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c04d42d5-5551-42f8-b768-ea2774c94bc1", "1" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("bdd2ac23-0353-489d-9201-0f1649e5f5c1"), "c04d42d5-5551-42f8-b768-ea2774c94bc1" });
        }
    }
}
