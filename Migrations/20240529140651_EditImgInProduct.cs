using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothes_Online_Shop.DB.Migrations
{
    public partial class EditImgInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImgInfos_Products_ProductId",
                table: "ImgInfos");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.RenameColumn(
                name: "Path",
                table: "ImgInfos",
                newName: "Url");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ImgInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Care", "Color", "Cost", "Country", "Description", "Fabric", "Item", "Like", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"), "Stone Island", "Деликатная машинная стирка", "Белый", 1199m, "USA", "Высокое качество по доступной цене", "80% хлопок 20% полиэстер", "st0171", false, "Зип худи шерпа с капюшоном", 50 },
                    { new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"), "Stone Island", "Деликатная машинная стирка", "Черный", 1499m, "USA", "Высокое качество по доступной цене", "80% хлопок 20% полиэстер", "st0170", false, "Зип худи шерпа с капюшоном", 52 },
                    { new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"), "Stone Island", "Ручная стирка", "Бежевый", 999m, "USA", "Лучшее сохранение тепла", "90% пух 10% полиэстер", "sk0500", false, "Пуховая жилетка", 49 },
                    { new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"), "Stone Island", "Ручная деликатная стирка при температуре на более 30", "Салатовый", 2999m, "USA", "Повседневный стиль", "100% хлопок", "wr0343", false, "Женский костюм", 33 }
                });

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductId",
                value: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 17,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 18,
                column: "ProductId",
                value: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 22,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 23,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductId",
                value: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.AddForeignKey(
                name: "FK_ImgInfos_Products_ProductId",
                table: "ImgInfos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImgInfos_Products_ProductId",
                table: "ImgInfos");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3172aff4-a749-427c-9e8c-a3090da3b5ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3cd289f8-ec1d-4c6f-aadc-2f0c9ef247e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("60aa37ab-2f22-4830-85db-7ca693751fd8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0473716-f9e7-411a-8984-9e1ca1efc61b"));

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "ImgInfos",
                newName: "Path");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ImgInfos",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Care", "Color", "Cost", "Country", "Description", "Fabric", "Item", "Like", "Name", "Size" },
                values: new object[,]
                {
                    { new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"), "Stone Island", "Деликатная машинная стирка", "Белый", 1199m, "USA", "Высокое качество по доступной цене", "80% хлопок 20% полиэстер", "st0171", false, "Зип худи шерпа с капюшоном", 50 },
                    { new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"), "Stone Island", "Деликатная машинная стирка", "Черный", 1499m, "USA", "Высокое качество по доступной цене", "80% хлопок 20% полиэстер", "st0170", false, "Зип худи шерпа с капюшоном", 52 },
                    { new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"), "Stone Island", "Ручная стирка", "Бежевый", 999m, "USA", "Лучшее сохранение тепла", "90% пух 10% полиэстер", "sk0500", false, "Пуховая жилетка", 49 },
                    { new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"), "Stone Island", "Ручная деликатная стирка при температуре на более 30", "Салатовый", 2999m, "USA", "Повседневный стиль", "100% хлопок", "wr0343", false, "Женский костюм", 33 }
                });

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 11,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 12,
                column: "ProductId",
                value: new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 13,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 14,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 15,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 16,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 17,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 18,
                column: "ProductId",
                value: new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 19,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 20,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 22,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 23,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.UpdateData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 24,
                column: "ProductId",
                value: new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a"));

            migrationBuilder.AddForeignKey(
                name: "FK_ImgInfos_Products_ProductId",
                table: "ImgInfos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
