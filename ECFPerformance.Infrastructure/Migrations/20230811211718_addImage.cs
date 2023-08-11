using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class addImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Turbos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "ProjectCars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "ConnectingRods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Turbos");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "ProjectCars");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "ConnectingRods");
        }
    }
}
