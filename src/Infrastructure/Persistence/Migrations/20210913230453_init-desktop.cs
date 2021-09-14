using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobnet.Store.Infrastructure.persistence.migrations
{
    public partial class initdesktop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c3f3977-a076-4aeb-8049-65403776a147"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24201844-255f-4306-ac89-826dfd6ebf0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3362771a-fced-4022-a28e-b6c609ebae31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4e556721-061f-4909-b76a-fd5ef42f2c22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("527ea81b-0763-456a-9ad3-e2af4a3e1900"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a78cfa-20f8-414f-a801-c612bdb5c0c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b5946c5-96df-42f9-96df-be9bdfbef4a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a5559516-eca2-4e00-9136-b2d7df34db96"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cef649da-736b-41a1-be58-35423163de23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea8e981e-8ad6-4e5c-9413-e0a75fbff456"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified", "MaxDiscount", "Name", "Price", "PurchasePrice", "Stock", "StockMin" },
                values: new object[,]
                {
                    { new Guid("17a20e63-32a2-4977-9909-329a7f3c1cfc"), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Biquine", 99.90m, 38.90m, 4m, 2m },
                    { new Guid("160a9220-a423-411a-93a7-a71b61ecea13"), 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Boné Nike", 12m, 24.90m, 5m, 3m },
                    { new Guid("1f905b97-bc23-4703-9cd9-f37e916c2cf3"), 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Snorkel", 14m, 29.90m, 8m, 4m },
                    { new Guid("0aca8a22-672f-4cbd-8b20-666eabcb8543"), 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Chapeu", 27.90m, 12m, 4m, 2m },
                    { new Guid("508d1dfc-a9a5-433a-8be5-d2506b9c9397"), 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Saída de Praia", 78.90m, 33m, 4m, 2m },
                    { new Guid("acd30637-92de-4934-8afd-ca8ecad060be"), 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Canga", 99.90m, 40m, 4m, 2m },
                    { new Guid("ea632815-3136-4d4d-95bc-9a65ccdeffad"), 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Óculos'", 19.90m, 8m, 10m, 5m },
                    { new Guid("2ecae2fc-ba62-44b3-b779-e19ec95418d4"), 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Namoradeira", 24.90m, 12m, 4m, 2m },
                    { new Guid("72904c7f-8501-4ca2-ba31-d99921b296bc"), 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Sunga", 29.90m, 17m, 10m, 4m },
                    { new Guid("577d2cb6-028b-4c86-bae2-7ba391ece741"), 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "UV", 59.90m, 23m, 18m, 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0aca8a22-672f-4cbd-8b20-666eabcb8543"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("160a9220-a423-411a-93a7-a71b61ecea13"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17a20e63-32a2-4977-9909-329a7f3c1cfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f905b97-bc23-4703-9cd9-f37e916c2cf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ecae2fc-ba62-44b3-b779-e19ec95418d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("508d1dfc-a9a5-433a-8be5-d2506b9c9397"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("577d2cb6-028b-4c86-bae2-7ba391ece741"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72904c7f-8501-4ca2-ba31-d99921b296bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("acd30637-92de-4934-8afd-ca8ecad060be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea632815-3136-4d4d-95bc-9a65ccdeffad"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Created", "Description", "LastModified", "MaxDiscount", "Name", "Price", "PurchasePrice", "Stock", "StockMin" },
                values: new object[,]
                {
                    { new Guid("68a78cfa-20f8-414f-a801-c612bdb5c0c1"), 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Biquine", 99.90m, 38.90m, 4m, 2m },
                    { new Guid("4e556721-061f-4909-b76a-fd5ef42f2c22"), 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preto", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Boné Nike", 12m, 24.90m, 5m, 3m },
                    { new Guid("cef649da-736b-41a1-be58-35423163de23"), 3L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Snorkel", 14m, 29.90m, 8m, 4m },
                    { new Guid("a5559516-eca2-4e00-9136-b2d7df34db96"), 4L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Chapeu", 27.90m, 12m, 4m, 2m },
                    { new Guid("24201844-255f-4306-ac89-826dfd6ebf0f"), 5L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Saída de Praia", 78.90m, 33m, 4m, 2m },
                    { new Guid("527ea81b-0763-456a-9ad3-e2af4a3e1900"), 6L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Canga", 99.90m, 40m, 4m, 2m },
                    { new Guid("6b5946c5-96df-42f9-96df-be9bdfbef4a7"), 7L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Óculos'", 19.90m, 8m, 10m, 5m },
                    { new Guid("ea8e981e-8ad6-4e5c-9413-e0a75fbff456"), 8L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pequena", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Namoradeira", 24.90m, 12m, 4m, 2m },
                    { new Guid("1c3f3977-a076-4aeb-8049-65403776a147"), 9L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "Sunga", 29.90m, 17m, 10m, 4m },
                    { new Guid("3362771a-fced-4022-a28e-b6c609ebae31"), 10L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m, "UV", 59.90m, 23m, 18m, 10m }
                });
        }
    }
}
