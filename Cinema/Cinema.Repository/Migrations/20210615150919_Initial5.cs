using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Repository.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e8cd6706-7ae7-49a8-ac98-a10f2a50d383", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8cd6706-7ae7-49a8-ac98-a10f2a50d383");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "0b631df2-6db5-4ae9-a3f6-f7066a671b7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "da9f438e-1d4b-4e44-957b-db9c198f83b6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8cd6706-7ae7-49a8-ac98-a10f2a50d383", 0, "1429e395-e1bf-4a0e-af27-e882b3a51f6c", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEM/7K18IDyQu0pS3xVmO+eXk1Js+usyTv+hF4lL6m33WTM3+W6hMa9gWB2FQh/3+Vg==", null, false, "f6679c09-6dad-405a-952c-3fa36530ef48", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e8cd6706-7ae7-49a8-ac98-a10f2a50d383", "1" });
        }
    }
}
