using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHL.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedEnumColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamEnum",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerEnum",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamEnum",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PlayerEnum",
                table: "Players");
        }
    }
}
