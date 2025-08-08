using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FineTracker.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeededUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateJoined", "Email", "IsActive", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3673), "dhruv.mehta@finova.tech", true, "Dhruv" },
                    { 2, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3674), "dhairya.sharma@finova.tech", true, "Dhairya" },
                    { 3, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3676), "tarun.gautam@finova.tech", true, "Tarun" },
                    { 4, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3677), "mukul.kumar@finova.tech", true, "Mukul" },
                    { 5, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3678), "gaurav.saini@finova.tech", true, "Gaurav" },
                    { 6, new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3679), "shrawan.khatri@finova.tech", true, "Shrawan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
