using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class shoppingCartTurbo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8f5df86-1735-46e3-a3bb-dd5b56855c76"));

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartTurbo",
                columns: table => new
                {
                    ShoppingCartsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurbosInCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartTurbo", x => new { x.ShoppingCartsId, x.TurbosInCartId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartTurbo_ShoppingCarts_ShoppingCartsId",
                        column: x => x.ShoppingCartsId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartTurbo_Turbos_TurbosInCartId",
                        column: x => x.TurbosInCartId,
                        principalTable: "Turbos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurboShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurboId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurboShoppingCart", x => new { x.ShoppingCartId, x.TurboId });
                    table.ForeignKey(
                        name: "FK_TurboShoppingCart_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurboShoppingCart_Turbos_TurboId",
                        column: x => x.TurboId,
                        principalTable: "Turbos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7463b1a4-635d-462c-879e-e2f4eaa74824"), 0, "8ef63267-541f-4ea2-8885-0df0844a4425", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEBQC4lYvk4le98qQml22/r6b5e3zE4b3Ig1XfTz+lS0PUdCkBIm0GPYJ77Av+fXOwg==", "+3594567891", false, "0f42cdc1-3334-41ca-b9b0-98edf2ec0bbc", false, "ecfperformance@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartTurbo_TurbosInCartId",
                table: "ShoppingCartTurbo",
                column: "TurbosInCartId");

            migrationBuilder.CreateIndex(
                name: "IX_TurboShoppingCart_TurboId",
                table: "TurboShoppingCart",
                column: "TurboId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartTurbo");

            migrationBuilder.DropTable(
                name: "TurboShoppingCart");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7463b1a4-635d-462c-879e-e2f4eaa74824"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f8f5df86-1735-46e3-a3bb-dd5b56855c76"), 0, "7b630566-395c-42fc-8884-a0b790ab0f07", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEFENtP89EBdhYDobCLPVxk5oUciRgd9i/iJ26MtrvyFCOBNjh8KbtdaUGujyIW5iaA==", "+3594567891", false, "d365c6e4-1f43-4734-946c-d74ebf42b483", false, "ecfperformance@gmail.com" });
        }
    }
}
