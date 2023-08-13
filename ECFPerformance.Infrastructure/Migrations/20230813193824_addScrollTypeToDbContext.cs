using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class addScrollTypeToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turbos_TurboScrollType_ScrollTypeId",
                table: "Turbos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurboScrollType",
                table: "TurboScrollType");

            migrationBuilder.RenameTable(
                name: "TurboScrollType",
                newName: "ScrollTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScrollTypes",
                table: "ScrollTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Turbos_ScrollTypes_ScrollTypeId",
                table: "Turbos",
                column: "ScrollTypeId",
                principalTable: "ScrollTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turbos_ScrollTypes_ScrollTypeId",
                table: "Turbos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScrollTypes",
                table: "ScrollTypes");

            migrationBuilder.RenameTable(
                name: "ScrollTypes",
                newName: "TurboScrollType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurboScrollType",
                table: "TurboScrollType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Turbos_TurboScrollType_ScrollTypeId",
                table: "Turbos",
                column: "ScrollTypeId",
                principalTable: "TurboScrollType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
