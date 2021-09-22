using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobnet.Store.Infrastructure.Persistence.Migrations
{
    public partial class addOrderName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f608da1-1a89-41e0-a66a-4c765f19207d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12b82aad-428e-4e97-bfef-61c87f476df1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2797ca38-7214-4652-b56a-b621ac325a35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("642529d6-cc3b-4339-a63e-47daddc076cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("728633ae-49ef-486d-ba64-8fd473a3cf75"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f6fc0b1-537d-4509-a24e-bfbb044c4bc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab59f523-75de-47f4-82c8-fa9c834f5648"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d04548a4-ab7d-472a-a860-59f2ea625dcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db923d3a-d419-49f9-955a-6f1f4bce7fb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d1ba89-b8a4-4a9b-b6c1-a13437d15783"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified", "MaxDiscount", "Name", "Price", "PurchasePrice", "Stock", "StockMin" },
                values: new object[,]
                {
                    { new Guid("0bc3a9e9-555c-4895-a229-142a30b061fa"), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Biquine", 99.90m, 38.90m, 4m, 2m },
                    { new Guid("157f6d24-5094-4f1d-8296-e31cf7d67105"), 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Boné Nike", 12m, 24.90m, 5m, 3m },
                    { new Guid("99f89f27-a304-4158-a870-70d09ff4638d"), 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Snorkel", 14m, 29.90m, 8m, 4m },
                    { new Guid("d76780d5-ae2e-4857-a77b-1d5f31fe0607"), 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Chapeu", 27.90m, 12m, 4m, 2m },
                    { new Guid("388fe520-f5df-431c-8069-5347475ea2d4"), 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Saída de Praia", 78.90m, 33m, 4m, 2m },
                    { new Guid("90d3481d-cfbb-42d8-ae86-296c8c604671"), 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Canga", 99.90m, 40m, 4m, 2m },
                    { new Guid("3f30671f-99c4-458e-bc48-3036c41f5412"), 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Óculos'", 19.90m, 8m, 10m, 5m },
                    { new Guid("2077e84d-3998-4b7d-9454-02063b6362c6"), 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Namoradeira", 24.90m, 12m, 4m, 2m },
                    { new Guid("0df40232-27a9-43a3-a69f-27a110f9a4a6"), 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Sunga", 29.90m, 17m, 10m, 4m },
                    { new Guid("780be182-9662-46d3-9dcc-a59f6f8dcc2b"), 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "UV", 59.90m, 23m, 18m, 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bc3a9e9-555c-4895-a229-142a30b061fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0df40232-27a9-43a3-a69f-27a110f9a4a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("157f6d24-5094-4f1d-8296-e31cf7d67105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2077e84d-3998-4b7d-9454-02063b6362c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("388fe520-f5df-431c-8069-5347475ea2d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f30671f-99c4-458e-bc48-3036c41f5412"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("780be182-9662-46d3-9dcc-a59f6f8dcc2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("90d3481d-cfbb-42d8-ae86-296c8c604671"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99f89f27-a304-4158-a870-70d09ff4638d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d76780d5-ae2e-4857-a77b-1d5f31fe0607"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderItem");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified", "MaxDiscount", "Name", "Price", "PurchasePrice", "Stock", "StockMin" },
                values: new object[,]
                {
                    { new Guid("728633ae-49ef-486d-ba64-8fd473a3cf75"), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Biquine", 99.90m, 38.90m, 4m, 2m },
                    { new Guid("0f608da1-1a89-41e0-a66a-4c765f19207d"), 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Boné Nike", 12m, 24.90m, 5m, 3m },
                    { new Guid("12b82aad-428e-4e97-bfef-61c87f476df1"), 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Snorkel", 14m, 29.90m, 8m, 4m },
                    { new Guid("db923d3a-d419-49f9-955a-6f1f4bce7fb5"), 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Chapeu", 27.90m, 12m, 4m, 2m },
                    { new Guid("642529d6-cc3b-4339-a63e-47daddc076cf"), 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Saída de Praia", 78.90m, 33m, 4m, 2m },
                    { new Guid("2797ca38-7214-4652-b56a-b621ac325a35"), 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Canga", 99.90m, 40m, 4m, 2m },
                    { new Guid("d04548a4-ab7d-472a-a860-59f2ea625dcf"), 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Óculos'", 19.90m, 8m, 10m, 5m },
                    { new Guid("7f6fc0b1-537d-4509-a24e-bfbb044c4bc5"), 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Namoradeira", 24.90m, 12m, 4m, 2m },
                    { new Guid("ab59f523-75de-47f4-82c8-fa9c834f5648"), 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Sunga", 29.90m, 17m, 10m, 4m },
                    { new Guid("e3d1ba89-b8a4-4a9b-b6c1-a13437d15783"), 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "UV", 59.90m, 23m, 18m, 10m }
                });
        }
    }
}
