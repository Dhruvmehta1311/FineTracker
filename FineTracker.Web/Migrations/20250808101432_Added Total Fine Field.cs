using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FineTracker.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedTotalFineField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalFine",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalFine",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateJoined",
                value: new DateTime(2025, 8, 8, 15, 3, 33, 985, DateTimeKind.Local).AddTicks(3679));
        }
    }
}
