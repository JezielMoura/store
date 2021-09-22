using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mobnet.Store.Infrastructure.Persistence.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c85699c-e881-4375-9dc6-dc0f30b56a7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7113137d-317e-4679-8530-f67b4a59d0f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("845a2abb-8eae-49b4-b9c1-daf199c4af30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89a8f1e7-c5ac-4310-a0d7-1cf322ef2a33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c19fffc4-0820-4a69-8d3c-4a0d7c1222bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2e5d554-691b-44e4-b20b-392f0398e85f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc714244-79b4-46ab-b93b-fe6b2897ee1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce04b782-d408-4ff4-b6ec-d195532fb1e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d882f561-e615-450c-adb8-4fd2e55cfc71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb623a4d-5e59-4e59-9633-eef4fb6d80a4"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified", "MaxDiscount", "Name", "Price", "PurchasePrice", "Stock", "StockMin" },
                values: new object[,]
                {
                    { new Guid("ce04b782-d408-4ff4-b6ec-d195532fb1e1"), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Biquine", 99.90m, 38.90m, 4m, 2m },
                    { new Guid("d882f561-e615-450c-adb8-4fd2e55cfc71"), 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Boné Nike", 12m, 24.90m, 5m, 3m },
                    { new Guid("845a2abb-8eae-49b4-b9c1-daf199c4af30"), 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Snorkel", 14m, 29.90m, 8m, 4m },
                    { new Guid("c19fffc4-0820-4a69-8d3c-4a0d7c1222bf"), 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Chapeu", 27.90m, 12m, 4m, 2m },
                    { new Guid("c2e5d554-691b-44e4-b20b-392f0398e85f"), 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Saída de Praia", 78.90m, 33m, 4m, 2m },
                    { new Guid("1c85699c-e881-4375-9dc6-dc0f30b56a7d"), 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Canga", 99.90m, 40m, 4m, 2m },
                    { new Guid("fb623a4d-5e59-4e59-9633-eef4fb6d80a4"), 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Óculos'", 19.90m, 8m, 10m, 5m },
                    { new Guid("7113137d-317e-4679-8530-f67b4a59d0f9"), 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Namoradeira", 24.90m, 12m, 4m, 2m },
                    { new Guid("cc714244-79b4-46ab-b93b-fe6b2897ee1c"), 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Sunga", 29.90m, 17m, 10m, 4m },
                    { new Guid("89a8f1e7-c5ac-4310-a0d7-1cf322ef2a33"), 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "UV", 59.90m, 23m, 18m, 10m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Products_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
