using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class add_categories_rods_cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EngineType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TurboScrollType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrollType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurboScrollType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConnectingRods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    PistonBoltDiameter = table.Column<int>(type: "int", nullable: false),
                    BeamType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConnectingRods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turbos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ScrollTypeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turbos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turbos_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turbos_TurboScrollType_ScrollTypeId",
                        column: x => x.ScrollTypeId,
                        principalTable: "TurboScrollType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectingRodEngineType",
                columns: table => new
                {
                    CompatibleEnginesId = table.Column<int>(type: "int", nullable: false),
                    ConnectingRodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRodEngineType", x => new { x.CompatibleEnginesId, x.ConnectingRodsId });
                    table.ForeignKey(
                        name: "FK_ConnectingRodEngineType_ConnectingRods_ConnectingRodsId",
                        column: x => x.ConnectingRodsId,
                        principalTable: "ConnectingRods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectingRodEngineType_EngineType_CompatibleEnginesId",
                        column: x => x.CompatibleEnginesId,
                        principalTable: "EngineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectingRodProjectCar",
                columns: table => new
                {
                    ConnectingRodsId = table.Column<int>(type: "int", nullable: false),
                    ProjectCarsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRodProjectCar", x => new { x.ConnectingRodsId, x.ProjectCarsId });
                    table.ForeignKey(
                        name: "FK_ConnectingRodProjectCar_ConnectingRods_ConnectingRodsId",
                        column: x => x.ConnectingRodsId,
                        principalTable: "ConnectingRods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectingRodProjectCar_ProjectCars_ProjectCarsId",
                        column: x => x.ProjectCarsId,
                        principalTable: "ProjectCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCarTurbo",
                columns: table => new
                {
                    ProjectCarsId = table.Column<int>(type: "int", nullable: false),
                    TurbosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCarTurbo", x => new { x.ProjectCarsId, x.TurbosId });
                    table.ForeignKey(
                        name: "FK_ProjectCarTurbo_ProjectCars_ProjectCarsId",
                        column: x => x.ProjectCarsId,
                        principalTable: "ProjectCars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectCarTurbo_Turbos_TurbosId",
                        column: x => x.TurbosId,
                        principalTable: "Turbos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRodEngineType_ConnectingRodsId",
                table: "ConnectingRodEngineType",
                column: "ConnectingRodsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRodProjectCar_ProjectCarsId",
                table: "ConnectingRodProjectCar",
                column: "ProjectCarsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRods_CategoryId",
                table: "ConnectingRods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCarTurbo_TurbosId",
                table: "ProjectCarTurbo",
                column: "TurbosId");

            migrationBuilder.CreateIndex(
                name: "IX_Turbos_CategoryId",
                table: "Turbos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Turbos_ScrollTypeId",
                table: "Turbos",
                column: "ScrollTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConnectingRodEngineType");

            migrationBuilder.DropTable(
                name: "ConnectingRodProjectCar");

            migrationBuilder.DropTable(
                name: "ProjectCarTurbo");

            migrationBuilder.DropTable(
                name: "EngineType");

            migrationBuilder.DropTable(
                name: "ConnectingRods");

            migrationBuilder.DropTable(
                name: "ProjectCars");

            migrationBuilder.DropTable(
                name: "Turbos");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TurboScrollType");
        }
    }
}
