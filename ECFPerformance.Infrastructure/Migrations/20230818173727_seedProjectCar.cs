using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class seedProjectCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d946c650-fe61-416d-a1b0-21212d139a20"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e1ff8939-3d7a-4c58-bf52-2a0f91455371"), 0, "e10998c7-b807-41b0-9b83-95de40b62893", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEHRzCyrGUq2PsIRb/Wtlms91zg7vA0owJNX285ULqpdhTu62v5cjZdnwQ4R7XMobng==", "+3594567891", false, "572a08d1-a231-40fc-8bf3-4da9dd028c2c", false, "ecfperformance@gmail.com" });

            migrationBuilder.InsertData(
                table: "ProjectCars",
                columns: new[] { "Id", "Description", "MainImage", "Name" },
                values: new object[] { 1, "Engine: \n - M50B28 stroker \n - ConnectingRods - Forged MaxPeedingRods \n - Pistons - From M40B18 Engine \n - Turbo - GT35 \n - HorsePower - ~ 400 \nChassis: \n - E36 Coupe \n - Angle Kit - WiseFab Replica", "/imgs/valkata.jpg", "E36 Coupe M50B28 Turbo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e1ff8939-3d7a-4c58-bf52-2a0f91455371"));

            migrationBuilder.DeleteData(
                table: "ProjectCars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d946c650-fe61-416d-a1b0-21212d139a20"), 0, "c23cde86-2d66-4b52-a991-b5cd51512205", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEBQG24R4SBCvg86zUPvJWJtlOjQEXx3+SnOYtibNbUwMRxHOJwaaZfokZmzWDBt++w==", "+3594567891", false, "3d3f9f4c-2767-4e74-a84e-7e68b277b140", false, "ecfperformance@gmail.com" });
        }
    }
}
