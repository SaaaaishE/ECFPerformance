using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class BeamType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamType_BeamTypeId",
                table: "ConnectingRods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConnectingRodBeamType",
                table: "ConnectingRodBeamType");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ef09a0c-cf3f-46e5-a8dc-b516a1800859"));

            migrationBuilder.RenameTable(
                name: "ConnectingRodBeamType",
                newName: "ConnectingRodBeamTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConnectingRodBeamTypes",
                table: "ConnectingRodBeamTypes",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4cc064f5-c1e6-4bf4-a49a-705fd2c61d43"), 0, "23535292-9d60-478f-95b8-57375b655b6f", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEGiFN6GHC8fc6Hq42zHJNv1cYoCpBWtoX8dIES+pX/VO6QgMFOnbIzIAYmVaOQ14yg==", "+3594567891", false, "d0d34884-d478-4a82-b456-833ebbe46e7e", false, "ecfperformance@gmail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamTypes_BeamTypeId",
                table: "ConnectingRods",
                column: "BeamTypeId",
                principalTable: "ConnectingRodBeamTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamTypes_BeamTypeId",
                table: "ConnectingRods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConnectingRodBeamTypes",
                table: "ConnectingRodBeamTypes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4cc064f5-c1e6-4bf4-a49a-705fd2c61d43"));

            migrationBuilder.RenameTable(
                name: "ConnectingRodBeamTypes",
                newName: "ConnectingRodBeamType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConnectingRodBeamType",
                table: "ConnectingRodBeamType",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8ef09a0c-cf3f-46e5-a8dc-b516a1800859"), 0, "e81ebc66-7d9c-4af2-89ee-72745e89efad", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEDKOLV24/VaDlLsCuTLZNP5/EcKyHngV2eUtjvbFLWxgw+Rpz6yOGQAhLIFgPxXm2w==", "+3594567891", false, "35a695c9-6b99-4b52-9eb5-01267e8bd5be", false, "ecfperformance@gmail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamType_BeamTypeId",
                table: "ConnectingRods",
                column: "BeamTypeId",
                principalTable: "ConnectingRodBeamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
