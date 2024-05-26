using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Supplier_config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Products",
                newName: "SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                newName: "IX_Products_SupplierId");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Suppliers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Category 1", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 975, DateTimeKind.Local).AddTicks(1672), "111.21.2.5", "Category 1 Description", true, new Guid("64033abd-3295-41d0-b40e-bfb346b4b3cb"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Category 2", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 975, DateTimeKind.Local).AddTicks(1780), "111.21.2.5", "Category 2 Description", true, new Guid("da8dfb9e-fa8d-4a34-a7a8-f3d9ea0fdbc1"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Category 3", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 975, DateTimeKind.Local).AddTicks(1784), "111.21.2.5", "Category 3 Description", true, new Guid("c3d0a5ae-8726-4309-8d77-4ae3142c3f5e"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "CompanyName", "ContactName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "IsActive", "MasterId", "PhoneNumber", "Status", "SupplierId", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Test Supplier Adress-1", "Test Supplier-1", "Test ContactName-11", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(5990), "111.21.2.5", true, new Guid("8a0df7c9-373c-4295-a517-2045275f4c92"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Test Supplier Adress-2", "Test Supplier-2", "Test ContactName-2", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(6000), "111.21.2.5", true, new Guid("d1b8f2b5-d3fa-40e9-9bca-f2adf9fcfcb7"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Test Supplier Adress-3", "Test Supplier-3", "Test ContactName-3", "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(6003), "111.21.2.5", true, new Guid("fc043e24-cd97-4700-af15-d8f57be250d2"), null, 0, 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "ImagePath", "IsActive", "MasterId", "ProductName", "Status", "SupplierId", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedData", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 11, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4313), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("6ef15449-0404-4b98-b87e-e3420cc1d4d8"), "Chicken", 0, 1, 5548.88m, (short)7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4615), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("c7283868-bf3a-4dad-8693-1c629be42d17"), "Mouse", 0, 1, 7612.26m, (short)40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4629), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("a3301cbc-95c1-46db-b827-3a4b01601653"), "Towels", 0, 1, 1903.13m, (short)95, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4641), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("bc73ba1e-8184-46f0-9585-46efb6dbb339"), "Shirt", 0, 1, 4724.01m, (short)10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4653), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("e5eb319d-3352-454e-a300-603cc303d10d"), "Shoes", 0, 1, 2427.38m, (short)68, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4663), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("3e37e602-08e8-4620-b295-4ffc2136e20e"), "Keyboard", 0, 1, 6682.05m, (short)73, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4686), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("184b3714-b310-4926-a1fe-46b7ae6c7e44"), "Fish", 0, 1, 9035.96m, (short)81, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4696), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("4c6e8f9a-7e95-40d0-9187-89e4eab0373d"), "Chicken", 0, 1, 4157.17m, (short)96, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4705), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("b30ea7f5-fcc9-42fb-921e-bddff619aaba"), "Computer", 0, 1, 200.80m, (short)10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 1, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4720), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("febb4526-be00-43a4-9515-3e64d1f95659"), "Gloves", 0, 1, 7037.81m, (short)63, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4730), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("859ac669-7710-4a4e-8f7c-f6d365d761c4"), "Keyboard", 0, 2, 4033.00m, (short)97, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4740), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("70c346a2-2302-4d64-ba66-d39d0b400ea0"), "Soap", 0, 2, 1029.23m, (short)18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4749), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("7e128390-0bae-4191-a556-1220dadc4082"), "Bike", 0, 2, 7536.03m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4760), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("92f57d3f-4d6d-4f01-9d42-35a91c800820"), "Mouse", 0, 2, 3084.72m, (short)84, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4772), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("1cdf3756-985a-49ed-a692-5b5648105d6d"), "Bike", 0, 2, 4492.03m, (short)69, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4782), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("17f02c78-5f4f-493b-a5c2-794a3b852063"), "Salad", 0, 2, 634.96m, (short)19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4791), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("7188a869-fdbb-4157-94fd-39b45641699e"), "Ball", 0, 2, 965.52m, (short)93, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4801), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("c767589d-346e-46dd-a968-cefdbb3bd036"), "Chips", 0, 2, 895.73m, (short)52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4811), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("47e040f7-3709-482d-b2e2-eab3a37cb976"), "Pizza", 0, 2, 4966.33m, (short)99, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 2, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4820), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("136d0aba-bd7c-4ab8-ad7b-bd738ac2847f"), "Sausages", 0, 2, 2739.76m, (short)28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4829), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("17268685-4666-479a-a545-1b25bb61851a"), "Computer", 0, 3, 1117.78m, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4840), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("67f8bfd7-4537-4fab-a271-902befd0dcfe"), "Mouse", 0, 3, 6267.57m, (short)17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4852), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("f5fbc2e8-8538-4748-90c6-9bf0b4975009"), "Salad", 0, 3, 699.77m, (short)21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4866), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("d91a38a1-6c6c-4f9f-9b52-8aebe1680117"), "Chips", 0, 3, 3026.80m, (short)92, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4875), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("b7141f23-ed60-4e9b-8387-361fd144d0a8"), "Keyboard", 0, 3, 3908.80m, (short)8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4884), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("3976cfc9-c480-43fb-8238-0c7f7fe1e91f"), "Sausages", 0, 3, 3955.16m, (short)7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4894), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("57f75d4d-0142-4ef8-9d0f-b835b2ed6ff0"), "Bike", 0, 3, 2523.89m, (short)16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4903), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("9ca3afa4-7d8c-4ac0-a80b-dbe616fa9652"), "Pizza", 0, 3, 6641.64m, (short)31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4912), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("49cf9e11-b8d3-44a0-a995-ada5ae2c92cc"), "Cheese", 0, 3, 9579.33m, (short)67, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 3, "LAPTOP-7RVI861P", new DateTime(2024, 5, 26, 9, 53, 54, 983, DateTimeKind.Local).AddTicks(4922), "111.21.2.5", "http://lorempixel.com/640/480/fashion", true, new Guid("a33a4720-952e-4db9-a924-30b080e3613f"), "Chair", 0, 3, 8368.69m, (short)42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Products",
                newName: "SupplierID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                newName: "IX_Products_SupplierID");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedIpAddress",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedComputerName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedComputerName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierID",
                table: "Products",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
