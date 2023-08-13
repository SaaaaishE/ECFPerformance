using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class addSequrityStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78d935fc-e47c-492d-b273-928ea9da229e"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f8f5df86-1735-46e3-a3bb-dd5b56855c76"), 0, "7b630566-395c-42fc-8884-a0b790ab0f07", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEFENtP89EBdhYDobCLPVxk5oUciRgd9i/iJ26MtrvyFCOBNjh8KbtdaUGujyIW5iaA==", "+3594567891", false, "d365c6e4-1f43-4734-946c-d74ebf42b483", false, "ecfperformance@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8f5df86-1735-46e3-a3bb-dd5b56855c76"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("78d935fc-e47c-492d-b273-928ea9da229e"), 0, "a9bfd4a4-7f4c-4c4a-b51c-ac182a38f15d", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEKIj/NqlB1oN9R0n9NuexliY+01e0o17deGRRlhh3Js99NF2vbJzrLR+dg7OHuWrJw==", "+3594567891", false, null, false, "ecfperformance@gmail.com" });
        }
    }
}
