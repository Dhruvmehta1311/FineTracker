using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FineTracker.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class SeededRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e3f24b1-d388-401d-ba4b-457f2fb4b10c", "dd7efb98-91df-44e2-9ae7-a54070c2da23", "Admin", "Admin" },
                    { "c3223a85-14ff-4807-8e6b-0c14da331e54", "b89f7bd2-ca55-4815-8d71-96ba2da44841", "User", "USER" },
                    { "f47f29c6-d2bc-404d-b9a5-cc638cfaa1aa", "9a70e1d2-3198-4ab5-a6b7-6fae8aadb439", "SuperAdmin", "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b492b01-f994-45a5-9072-4aca8ae838c6", 0, "0c97c3cd-b330-4c61-8288-60c9cc454653", "dhruv@finetracker.dev", true, false, null, "DHRUV@FINETRACKER.DEV", "DHRUV", "AQAAAAIAAYagAAAAEFMqAjAhNhOecdi+vPKeWKOkd/3aYJZNXPIfxq7RDOHZpgp12dEyDZ0xvfXKSdG/JA==", null, false, "657a9fe3-4b84-498b-b855-dc15cc1279ae", false, "Dhruv" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f47f29c6-d2bc-404d-b9a5-cc638cfaa1aa", "5b492b01-f994-45a5-9072-4aca8ae838c6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e3f24b1-d388-401d-ba4b-457f2fb4b10c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3223a85-14ff-4807-8e6b-0c14da331e54");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f47f29c6-d2bc-404d-b9a5-cc638cfaa1aa", "5b492b01-f994-45a5-9072-4aca8ae838c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f47f29c6-d2bc-404d-b9a5-cc638cfaa1aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b492b01-f994-45a5-9072-4aca8ae838c6");
        }
    }
}
