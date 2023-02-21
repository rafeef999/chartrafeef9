using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class dbbbbm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_chartt",
                table: "chartt");

            migrationBuilder.RenameTable(
                name: "chartt",
                newName: "charttdb");

            migrationBuilder.AddPrimaryKey(
                name: "PK_charttdb",
                table: "charttdb",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_charttdb",
                table: "charttdb");

            migrationBuilder.RenameTable(
                name: "charttdb",
                newName: "chartt");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chartt",
                table: "chartt",
                column: "ID");
        }
    }
}
