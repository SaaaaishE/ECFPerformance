using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class nz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf48d8c9-b475-4a6b-8f43-b4c7b336e824"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9b7e5024-a088-4976-8349-b45e1f923750"), 0, "5875d253-5141-402a-9fbc-813b8e0597b3", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAELV36hvHwXQZ0pSodqmKDOpEfV8ln+fYp6JWaLJykoae5JJ4NwWfEB5Pkeuy3MB0lA==", "+3594567891", false, "fd413afd-d212-4792-8b5f-621b08a98077", false, "ecfperformance@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b7e5024-a088-4976-8349-b45e1f923750"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cf48d8c9-b475-4a6b-8f43-b4c7b336e824"), 0, "2ef03972-799d-4316-8d89-f0bb4cd63c96", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEFqov+ahyCNXRj3bx9ceNgIkvvwUC+ofRXnUid5yAvmqhlBgJRnYKAPXMD/vWz/Nlg==", "+3594567891", false, "c218220a-af52-4306-8b31-8ec54ad6ce32", false, "ecfperformance@gmail.com" });
        }
    }
}
