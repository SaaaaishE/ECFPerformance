using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class implementOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9b7e5024-a088-4976-8349-b45e1f923750"));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1ab2fe85-1718-4c3a-895b-3885d854f91e"), 0, "7bf85741-e21e-4898-80f8-9db2722d3370", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAENs+xtRUGEWJqYDYa8+y2Sn4t8OKZAJaQp1L9Xdp6yJmaTWAHQSHaTOxRwqAqfk7fQ==", "+3594567891", false, "1be49b45-0925-40c5-951e-a8139dc6694f", false, "ecfperformance@gmail.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ab2fe85-1718-4c3a-895b-3885d854f91e"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("9b7e5024-a088-4976-8349-b45e1f923750"), 0, "5875d253-5141-402a-9fbc-813b8e0597b3", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAELV36hvHwXQZ0pSodqmKDOpEfV8ln+fYp6JWaLJykoae5JJ4NwWfEB5Pkeuy3MB0lA==", "+3594567891", false, "fd413afd-d212-4792-8b5f-621b08a98077", false, "ecfperformance@gmail.com" });
        }
    }
}
