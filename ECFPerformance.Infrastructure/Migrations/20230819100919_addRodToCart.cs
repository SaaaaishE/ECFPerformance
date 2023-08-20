using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class addRodToCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4cc064f5-c1e6-4bf4-a49a-705fd2c61d43"));

            migrationBuilder.CreateTable(
                name: "ConnectingRodShoppingCart",
                columns: table => new
                {
                    ConnectingRodsId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRodShoppingCart", x => new { x.ConnectingRodsId, x.ShoppingCartsId });
                    table.ForeignKey(
                        name: "FK_ConnectingRodShoppingCart_ConnectingRods_ConnectingRodsId",
                        column: x => x.ConnectingRodsId,
                        principalTable: "ConnectingRods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectingRodShoppingCart_ShoppingCarts_ShoppingCartsId",
                        column: x => x.ShoppingCartsId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("7e0f06d1-1012-4e8f-a734-a54d1864f9ae"), 0, "0a7bdef6-0c29-40ae-808d-e3e9ed915d61", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEGb7k6ZKMoOXDveOpsNeT8ZPP+DLTFEZ/C37/Er1Dm6QON8Yp1GqXM1F2wflcYafnA==", "+3594567891", false, "d79ad9ef-73a4-433e-86a4-eb4fca3018d3", false, "ecfperformance@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRodShoppingCart_ShoppingCartsId",
                table: "ConnectingRodShoppingCart",
                column: "ShoppingCartsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectingRodShoppingCart");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e0f06d1-1012-4e8f-a734-a54d1864f9ae"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4cc064f5-c1e6-4bf4-a49a-705fd2c61d43"), 0, "23535292-9d60-478f-95b8-57375b655b6f", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEGiFN6GHC8fc6Hq42zHJNv1cYoCpBWtoX8dIES+pX/VO6QgMFOnbIzIAYmVaOQ14yg==", "+3594567891", false, "d0d34884-d478-4a82-b456-833ebbe46e7e", false, "ecfperformance@gmail.com" });
        }
    }
}
