using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class seedRods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a73fc76-579a-47bd-8852-52d4509311a9"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8ef09a0c-cf3f-46e5-a8dc-b516a1800859"), 0, "e81ebc66-7d9c-4af2-89ee-72745e89efad", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEDKOLV24/VaDlLsCuTLZNP5/EcKyHngV2eUtjvbFLWxgw+Rpz6yOGQAhLIFgPxXm2w==", "+3594567891", false, "35a695c9-6b99-4b52-9eb5-01267e8bd5be", false, "ecfperformance@gmail.com" });

            migrationBuilder.InsertData(
                table: "ConnectingRods",
                columns: new[] { "Id", "BeamTypeId", "CategoryId", "Length", "MainImage", "Make", "Name", "PistonBoltDiameter", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 135, "https://www.eaglerod.com/images/1c475ca0-bfd5-11ea-b02a-c48ef5f8d3b6/jpg/5313-4340-h-beam-bmw-38-arp-2000-bolts/crs-5313b63d-1.jpg", "Eagle", "BMW Beam Type I Connecting Rod 135mm", 22, 670m, 3 },
                    { 2, 2, 1, 135, "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-6/default/main/forged-rods-cr-6(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp", "MaxPeedingRods", "BMW Beam Type H Connecting Rod 135mm", 22, 580m, 3 },
                    { 3, 2, 1, 133, "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000", "MaxPeedingRods", "Mazda H Beam ", 20, 357m, 3 },
                    { 4, 1, 1, 133, "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/84c3ce8a-bfd5-11ea-87b6-e6954ea1f6b1.jpg", "Eagle", "Mazda I Beam", 20, 460m, 3 },
                    { 5, 2, 1, 137, "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp", "MaxPeedingRods", "Honda H Beam", 19, 359m, 3 },
                    { 6, 1, 1, 137, "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/870fa77e-bfd3-11ea-b02b-15c463fe2bce.jpg", "Eagle", "Honda I Beam", 19, 465m, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8ef09a0c-cf3f-46e5-a8dc-b516a1800859"));

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ConnectingRods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8a73fc76-579a-47bd-8852-52d4509311a9"), 0, "0fe1b535-5004-4474-8275-a06dea4b1378", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEO1c9Wtq6A4/oXUdD4myNp7R8cW9E6pWUVuSzwdN3wz+HR6O+M/F9+oPrXCpjYCIEw==", "+3594567891", false, "5b99cafb-fcaa-4778-bab6-5ee73669904e", false, "ecfperformance@gmail.com" });
        }
    }
}
