using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class CreateAndSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRodEngineType_ConnectingRods_ConnectingRodsId",
                table: "ConnectingRodEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRodEngineType_EngineType_CompatibleEnginesId",
                table: "ConnectingRodEngineType");

            migrationBuilder.RenameColumn(
                name: "BeamType",
                table: "ConnectingRods",
                newName: "BeamTypeId");

            migrationBuilder.RenameColumn(
                name: "ConnectingRodsId",
                table: "ConnectingRodEngineType",
                newName: "CompatibleRodId");

            migrationBuilder.RenameColumn(
                name: "CompatibleEnginesId",
                table: "ConnectingRodEngineType",
                newName: "CompatibleEngineId");

            migrationBuilder.RenameIndex(
                name: "IX_ConnectingRodEngineType_ConnectingRodsId",
                table: "ConnectingRodEngineType",
                newName: "IX_ConnectingRodEngineType_CompatibleRodId");

            migrationBuilder.CreateTable(
                name: "ConnectingRodBeamType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectingRodBeam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRodBeamType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Engine" },
                    { 2, "Chassis" },
                    { 3, "Suspension" },
                    { 4, "Exhaust" }
                });

            migrationBuilder.InsertData(
                table: "ConnectingRodBeamType",
                columns: new[] { "Id", "ConnectingRodBeam" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "EngineType",
                columns: new[] { "Id", "EngineCode" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 4 },
                    { 4, 5 },
                    { 5, 2 },
                    { 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "TurboScrollType",
                columns: new[] { "Id", "ScrollType" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 0 }
                });

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

            migrationBuilder.InsertData(
                table: "Turbos",
                columns: new[] { "Id", "CategoryId", "MainImage", "Make", "Name", "Price", "Quantity", "ScrollTypeId" },
                values: new object[,]
                {
                    { 1, 1, "https://m.media-amazon.com/images/I/612l0wYluUL._AC_SX522_.jpg", "MaxPeedingRods", "GT30", 130.00m, 3, 1 },
                    { 2, 1, "https://s19529.pcdn.co/wp-content/uploads/2021/02/Screen-Shot-2021-02-22-at-10.05.38-AM.png", "MaxPeedingRods", "GT35", 230.00m, 3, 1 },
                    { 3, 1, "https://th.bing.com/th/id/OIP.z3vjnJxtodUyIYBQigac8gHaGw?pid=ImgDet&rs=1", "Holset", "HX40", 500.00m, 3, 2 },
                    { 4, 1, "https://th.bing.com/th/id/R.145fdefb10871f3b499c8e9bbc1ff9c8?rik=w4kn89cj4XnJlw&pid=ImgRaw&r=0", "Holset", "HX35", 450.00m, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "ConnectingRodEngineType",
                columns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 3 },
                    { 6, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRods_BeamTypeId",
                table: "ConnectingRods",
                column: "BeamTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRodEngineType_ConnectingRods_CompatibleRodId",
                table: "ConnectingRodEngineType",
                column: "CompatibleRodId",
                principalTable: "ConnectingRods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRodEngineType_EngineType_CompatibleEngineId",
                table: "ConnectingRodEngineType",
                column: "CompatibleEngineId",
                principalTable: "EngineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamType_BeamTypeId",
                table: "ConnectingRods",
                column: "BeamTypeId",
                principalTable: "ConnectingRodBeamType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRodEngineType_ConnectingRods_CompatibleRodId",
                table: "ConnectingRodEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRodEngineType_EngineType_CompatibleEngineId",
                table: "ConnectingRodEngineType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConnectingRods_ConnectingRodBeamType_BeamTypeId",
                table: "ConnectingRods");

            migrationBuilder.DropTable(
                name: "ConnectingRodBeamType");

            migrationBuilder.DropIndex(
                name: "IX_ConnectingRods_BeamTypeId",
                table: "ConnectingRods");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ConnectingRodEngineType",
                keyColumns: new[] { "CompatibleEngineId", "CompatibleRodId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Turbos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turbos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turbos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turbos",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EngineType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TurboScrollType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TurboScrollType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "BeamTypeId",
                table: "ConnectingRods",
                newName: "BeamType");

            migrationBuilder.RenameColumn(
                name: "CompatibleRodId",
                table: "ConnectingRodEngineType",
                newName: "ConnectingRodsId");

            migrationBuilder.RenameColumn(
                name: "CompatibleEngineId",
                table: "ConnectingRodEngineType",
                newName: "CompatibleEnginesId");

            migrationBuilder.RenameIndex(
                name: "IX_ConnectingRodEngineType_CompatibleRodId",
                table: "ConnectingRodEngineType",
                newName: "IX_ConnectingRodEngineType_ConnectingRodsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRodEngineType_ConnectingRods_ConnectingRodsId",
                table: "ConnectingRodEngineType",
                column: "ConnectingRodsId",
                principalTable: "ConnectingRods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConnectingRodEngineType_EngineType_CompatibleEnginesId",
                table: "ConnectingRodEngineType",
                column: "CompatibleEnginesId",
                principalTable: "EngineType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
