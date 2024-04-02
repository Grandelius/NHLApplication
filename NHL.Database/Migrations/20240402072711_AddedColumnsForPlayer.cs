using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHL.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedColumnsForPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Founded",
                table: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "AverageTimeOnIce",
                table: "PlayerStatistics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "PlayerStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PpGoals",
                table: "PlayerStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PpPoints",
                table: "PlayerStatistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BirthPlace",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadShotImage",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shoots",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageTimeOnIce",
                table: "PlayerStatistics");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "PlayerStatistics");

            migrationBuilder.DropColumn(
                name: "PpGoals",
                table: "PlayerStatistics");

            migrationBuilder.DropColumn(
                name: "PpPoints",
                table: "PlayerStatistics");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "BirthPlace",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "HeadShotImage",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Shoots",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "Founded",
                table: "Teams",
                type: "int",
                nullable: true);
        }
    }
}
