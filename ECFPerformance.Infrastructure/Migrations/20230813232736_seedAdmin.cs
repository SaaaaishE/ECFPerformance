using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class seedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("78d935fc-e47c-492d-b273-928ea9da229e"), 0, "a9bfd4a4-7f4c-4c4a-b51c-ac182a38f15d", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEKIj/NqlB1oN9R0n9NuexliY+01e0o17deGRRlhh3Js99NF2vbJzrLR+dg7OHuWrJw==", "+3594567891", false, null, false, "ecfperformance@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78d935fc-e47c-492d-b273-928ea9da229e"));
        }
    }
}
