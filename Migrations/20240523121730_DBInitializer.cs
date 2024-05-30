using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clothes_Online_Shop.DB.Migrations
{
    public partial class DBInitializer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ImgInfos",
                columns: new[] { "Id", "Path", "ProductId" },
                values: new object[,]
                {
                    { 1, "/img/hudi-white-1.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 22, "/img/woman-costume-4.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") },
                    { 21, "/img/woman-costume-3.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") },
                    { 20, "/img/woman-costume-2.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") },
                    { 19, "/img/woman-costume-1.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") },
                    { 18, "/img/vest-6.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 17, "/img/vest-5.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 16, "/img/vest-4.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 15, "/img/vest-3.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 14, "/img/vest-2.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 13, "/img/vest-1.jpg", new Guid("99a9ffa1-276a-4763-9ad3-3de28051301e") },
                    { 12, "/img/hudi-black-6.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 11, "/img/hudi-black-5.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 10, "/img/hudi-black-4.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 9, "/img/hudi-black-3.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 8, "/img/hudi-black-2.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 7, "/img/hudi-black-1.jpg", new Guid("3bd9d4c5-19c7-4a98-90f3-c9f7d721270e") },
                    { 6, "/img/hudi-white-6.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 5, "/img/hudi-white-5.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 4, "/img/hudi-white-4.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 3, "/img/hudi-white-3.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 2, "/img/hudi-white-2.jpg", new Guid("1e34fb36-0e9e-4c86-b612-6edb791bb9c3") },
                    { 23, "/img/woman-costume-5.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") },
                    { 24, "/img/woman-costume-6.jpg", new Guid("85fd9358-fc59-481f-9e7c-ec7ffdcfb19a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ImgInfos",
                keyColumn: "Id",
                keyValue: 24);

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
        }
    }
}
