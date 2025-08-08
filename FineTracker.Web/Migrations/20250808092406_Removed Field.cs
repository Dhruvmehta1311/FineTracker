using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FineTracker.Web.Migrations
{
    /// <inheritdoc />
    public partial class RemovedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Fines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Fines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
