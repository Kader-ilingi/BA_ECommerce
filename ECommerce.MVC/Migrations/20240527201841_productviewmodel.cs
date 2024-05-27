using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class productviewmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Category 1", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 854, DateTimeKind.Local).AddTicks(2835), "111.21.2.5", "Category 1 Description", true, new Guid("ea680a73-f45c-42e1-aa31-0ce552bd1e7c"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Category 2", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 854, DateTimeKind.Local).AddTicks(2957), "111.21.2.5", "Category 2 Description", true, new Guid("2a7d48cb-95ff-4a72-a592-671ac17382a5"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Category 3", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 854, DateTimeKind.Local).AddTicks(2960), "111.21.2.5", "Category 3 Description", true, new Guid("7549c393-85f9-4ef9-9e81-cc4fa62078d3"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "SupplierId", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress-1", "Test Supplier-1", "Test ContactName-11", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 857, DateTimeKind.Local).AddTicks(1463), "111.21.2.5", true, new Guid("0c638ef4-4ee3-4647-9712-1c860e1d59ca"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Test Supplier Adress-2", "Test Supplier-2", "Test ContactName-2", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 857, DateTimeKind.Local).AddTicks(1473), "111.21.2.5", true, new Guid("b29bd058-3ca3-4a55-bca5-8086d72fd169"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Test Supplier Adress-3", "Test Supplier-3", "Test ContactName-3", "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 857, DateTimeKind.Local).AddTicks(1476), "111.21.2.5", true, new Guid("100db8ab-4980-4bcc-9152-d2f2ad0a4c32"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 11, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(8823), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("474b2938-6727-4c37-a61c-4159f7647113"), "Chicken", 0, 1, 1640.39m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9242), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("51094d0a-0add-46a5-a06b-2c9500986b2c"), "Car", 0, 1, 5692.31m, (short)36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9259), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("b8944919-624d-4517-843b-d5be5663ec25"), "Bacon", 0, 1, 3985.11m, (short)18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9273), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("88b79039-7275-4397-9a2e-3d019652c68a"), "Cheese", 0, 1, 8588.06m, (short)25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9286), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("7299b0d9-d52b-44ef-b500-aaa595d5dd40"), "Sausages", 0, 1, 6645.10m, (short)22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9317), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("7a12ae0e-4ad1-4d05-9c10-05cc9f77b5bd"), "Bacon", 0, 1, 3274.97m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9328), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("4b95a7cc-1fcc-44f0-b513-d192b833d53f"), "Cheese", 0, 1, 6733.85m, (short)64, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9339), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("ae5fcc68-f692-4645-bf1e-b1c855453a50"), "Soap", 0, 1, 4066.36m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9351), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("6ef50dab-48db-417a-9842-ed2a4a1ec840"), "Shoes", 0, 1, 9400.84m, (short)42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9364), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("af29dd3b-f713-43bf-9d0a-01592aadaad0"), "Car", 0, 1, 5964.66m, (short)48, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9375), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("8b0f31e5-9dc2-4ed4-8fc7-267dcee72e5f"), "Mouse", 0, 2, 9101.63m, (short)97, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9437), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("91961f83-3678-49fb-b6ea-7a2172136ca6"), "Sausages", 0, 2, 4847.00m, (short)52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9449), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("fddda2d4-f327-467b-b3e5-4b1b2ffbde66"), "Pizza", 0, 2, 3112.04m, (short)90, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9638), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("648f6b35-ab5f-4dfb-86cf-42ce0dc0914e"), "Chicken", 0, 2, 343.16m, (short)38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9649), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("3c141bf5-d5e5-4bdc-a055-aecca6964ffe"), "Shirt", 0, 2, 741.18m, (short)83, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9662), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("ae4912ab-a8c9-4943-aab8-491afc4b358b"), "Shoes", 0, 2, 5655.76m, (short)76, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9673), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("6b66d440-3588-4a2c-a4a1-7366587c2437"), "Gloves", 0, 2, 6526.29m, (short)28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9686), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("78038d1d-1a7d-432f-9895-3e0f23a8371a"), "Chips", 0, 2, 602.50m, (short)83, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9697), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("024e2973-dfca-46c4-a3da-f7caed6fdbba"), "Keyboard", 0, 2, 8223.16m, (short)49, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9709), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("9894ff82-83d1-4b4f-890b-49b9dc48ef5e"), "Chicken", 0, 2, 2059.44m, (short)29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9720), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("8c9936d0-4a34-4b66-a9db-d03488c95f5c"), "Computer", 0, 3, 8225.77m, (short)59, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9733), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("bba0eb38-b9b5-4cf6-9556-b2c68ccc2f56"), "Bacon", 0, 3, 6878.69m, (short)35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9744), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("01a68aa5-52d4-45e9-a798-ad9111fb0b47"), "Chicken", 0, 3, 3502.25m, (short)86, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9755), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("41cca8b0-4ef5-432c-b1f7-0a68bf2fd82c"), "Shirt", 0, 3, 2218.63m, (short)13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9765), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("55c99fc6-e6ba-4378-91df-498a6c22e9ca"), "Towels", 0, 3, 8066.32m, (short)39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9839), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("b2c3c01e-a4a1-4626-a7be-1596daa0052a"), "Table", 0, 3, 7659.45m, (short)87, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9885), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("78cc29a5-c8a4-42ff-87a4-726faa183908"), "Chair", 0, 3, 2306.85m, (short)66, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9899), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("2badb95b-72a9-4ba2-b5ed-5b0ba07c0a42"), "Salad", 0, 3, 4043.35m, (short)61, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9911), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("42217c87-c713-4323-b462-7414efffa6a6"), "Mouse", 0, 3, 917.36m, (short)15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 27, 23, 18, 40, 856, DateTimeKind.Local).AddTicks(9924), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("7cd7f736-4b04-429b-b2e6-cb54512c7ee0"), "Sausages", 0, 3, 8672.92m, (short)53, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
