using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class turboShoppingCartToDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurboShoppingCart_ShoppingCarts_ShoppingCartId",
                table: "TurboShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_TurboShoppingCart_Turbos_TurboId",
                table: "TurboShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurboShoppingCart",
                table: "TurboShoppingCart");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7463b1a4-635d-462c-879e-e2f4eaa74824"));

            migrationBuilder.RenameTable(
                name: "TurboShoppingCart",
                newName: "TurbosShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_TurboShoppingCart_TurboId",
                table: "TurbosShoppingCarts",
                newName: "IX_TurbosShoppingCarts_TurboId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurbosShoppingCarts",
                table: "TurbosShoppingCarts",
                columns: new[] { "ShoppingCartId", "TurboId" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("685b497f-2221-43bc-b994-d2597d08fec0"), 0, "41622b62-f025-4833-a3f0-41a6358c54db", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEGjrsgUKyInA5/xTS690ne/XuX4konB2+eRtWMoHov0qz7fraU9LHM7CNTbnE3/ddQ==", "+3594567891", false, "05af2d01-d258-4f2a-9e18-21bc08b5508f", false, "ecfperformance@gmail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_TurbosShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "TurbosShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurbosShoppingCarts_Turbos_TurboId",
                table: "TurbosShoppingCarts",
                column: "TurboId",
                principalTable: "Turbos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TurbosShoppingCarts_ShoppingCarts_ShoppingCartId",
                table: "TurbosShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_TurbosShoppingCarts_Turbos_TurboId",
                table: "TurbosShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TurbosShoppingCarts",
                table: "TurbosShoppingCarts");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("685b497f-2221-43bc-b994-d2597d08fec0"));

            migrationBuilder.RenameTable(
                name: "TurbosShoppingCarts",
                newName: "TurboShoppingCart");

            migrationBuilder.RenameIndex(
                name: "IX_TurbosShoppingCarts_TurboId",
                table: "TurboShoppingCart",
                newName: "IX_TurboShoppingCart_TurboId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TurboShoppingCart",
                table: "TurboShoppingCart",
                columns: new[] { "ShoppingCartId", "TurboId" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7463b1a4-635d-462c-879e-e2f4eaa74824"), 0, "8ef63267-541f-4ea2-8885-0df0844a4425", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEBQC4lYvk4le98qQml22/r6b5e3zE4b3Ig1XfTz+lS0PUdCkBIm0GPYJ77Av+fXOwg==", "+3594567891", false, "0f42cdc1-3334-41ca-b9b0-98edf2ec0bbc", false, "ecfperformance@gmail.com" });

            migrationBuilder.AddForeignKey(
                name: "FK_TurboShoppingCart_ShoppingCarts_ShoppingCartId",
                table: "TurboShoppingCart",
                column: "ShoppingCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurboShoppingCart_Turbos_TurboId",
                table: "TurboShoppingCart",
                column: "TurboId",
                principalTable: "Turbos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
