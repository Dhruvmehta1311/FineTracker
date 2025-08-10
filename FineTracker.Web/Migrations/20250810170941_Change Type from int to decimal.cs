using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FineTracker.Web.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTypefrominttodecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalFine",
                table: "Users",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6712), 0m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6714), 0m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6715), 0m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6718), 0m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6719), 0m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 10, 22, 39, 40, 558, DateTimeKind.Local).AddTicks(6720), 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalFine",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3265), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3267), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3268), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3270), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3271), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateJoined", "TotalFine" },
                values: new object[] { new DateTime(2025, 8, 8, 15, 44, 31, 809, DateTimeKind.Local).AddTicks(3272), 0 });
        }
    }
}
