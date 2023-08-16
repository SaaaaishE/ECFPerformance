using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECFPerformance.Infrastructure.Migrations
{
    public partial class innitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScrollTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScrollType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScrollTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "ConnectingRods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    PistonBoltDiameter = table.Column<int>(type: "int", nullable: false),
                    BeamTypeId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_ConnectingRods_ConnectingRodBeamType_BeamTypeId",
                        column: x => x.BeamTypeId,
                        principalTable: "ConnectingRodBeamType",
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
                    MainImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Turbos_ScrollTypes_ScrollTypeId",
                        column: x => x.ScrollTypeId,
                        principalTable: "ScrollTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConnectingRodEngineType",
                columns: table => new
                {
                    CompatibleEngineId = table.Column<int>(type: "int", nullable: false),
                    CompatibleRodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectingRodEngineType", x => new { x.CompatibleEngineId, x.CompatibleRodId });
                    table.ForeignKey(
                        name: "FK_ConnectingRodEngineType_ConnectingRods_CompatibleRodId",
                        column: x => x.CompatibleRodId,
                        principalTable: "ConnectingRods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConnectingRodEngineType_EngineType_CompatibleEngineId",
                        column: x => x.CompatibleEngineId,
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

            migrationBuilder.CreateTable(
                name: "ShoppingCartTurbo",
                columns: table => new
                {
                    ShoppingCartsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurbosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartTurbo", x => new { x.ShoppingCartsId, x.TurbosId });
                    table.ForeignKey(
                        name: "FK_ShoppingCartTurbo_ShoppingCarts_ShoppingCartsId",
                        column: x => x.ShoppingCartsId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartTurbo_Turbos_TurbosId",
                        column: x => x.TurbosId,
                        principalTable: "Turbos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("cf48d8c9-b475-4a6b-8f43-b4c7b336e824"), 0, "2ef03972-799d-4316-8d89-f0bb4cd63c96", "ecfperformance@gmail.com", false, "Alex", "Gavrilov", false, null, "ecfperformance@gmail.com", "ecfperformance@gmail.com", "AQAAAAEAACcQAAAAEFqov+ahyCNXRj3bx9ceNgIkvvwUC+ofRXnUid5yAvmqhlBgJRnYKAPXMD/vWz/Nlg==", "+3594567891", false, "c218220a-af52-4306-8b31-8ec54ad6ce32", false, "ecfperformance@gmail.com" });

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
                table: "ScrollTypes",
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRodEngineType_CompatibleRodId",
                table: "ConnectingRodEngineType",
                column: "CompatibleRodId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRodProjectCar_ProjectCarsId",
                table: "ConnectingRodProjectCar",
                column: "ProjectCarsId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRods_BeamTypeId",
                table: "ConnectingRods",
                column: "BeamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConnectingRods_CategoryId",
                table: "ConnectingRods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCarTurbo_TurbosId",
                table: "ProjectCarTurbo",
                column: "TurbosId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartTurbo_TurbosId",
                table: "ShoppingCartTurbo",
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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConnectingRodEngineType");

            migrationBuilder.DropTable(
                name: "ConnectingRodProjectCar");

            migrationBuilder.DropTable(
                name: "ProjectCarTurbo");

            migrationBuilder.DropTable(
                name: "ShoppingCartTurbo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EngineType");

            migrationBuilder.DropTable(
                name: "ConnectingRods");

            migrationBuilder.DropTable(
                name: "ProjectCars");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Turbos");

            migrationBuilder.DropTable(
                name: "ConnectingRodBeamType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ScrollTypes");
        }
    }
}
