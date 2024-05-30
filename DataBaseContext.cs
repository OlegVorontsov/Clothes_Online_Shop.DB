using Clothes_Online_Shop.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ImgInfo> ImgInfos { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImgInfo>()
                        .HasOne(p => p.Product)
                        .WithMany(p => p.ImgList)
                        .HasForeignKey(p => p.ProductId)
                        .OnDelete(DeleteBehavior.Cascade);

            var hudiWhite = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Зип худи шерпа с капюшоном",
                Item = "st0171",
                Cost = 1199,
                Size = 50,
                Color = "Белый",
                Care = "Деликатная машинная стирка",
                Fabric = "80% хлопок 20% полиэстер",
                Brand = "Stone Island",
                Country = "USA",
                Description = "Высокое качество по доступной цене",
                Like = false
            };
            var hudiBlack = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Зип худи шерпа с капюшоном",
                Item = "st0170",
                Cost = 1499,
                Size = 52,
                Color = "Черный",
                Care = "Деликатная машинная стирка",
                Fabric = "80% хлопок 20% полиэстер",
                Brand = "Stone Island",
                Country = "USA",
                Description = "Высокое качество по доступной цене",
                Like = false
            };
            var vest = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Пуховая жилетка",
                Item = "sk0500",
                Cost = 999,
                Size = 49,
                Color = "Бежевый",
                Care = "Ручная стирка",
                Fabric = "90% пух 10% полиэстер",
                Brand = "Stone Island",
                Country = "USA",
                Description = "Лучшее сохранение тепла",
                Like = false
            };
            var womanCostume = new Product()
            {
                Id = Guid.NewGuid(),
                Name = "Женский костюм",
                Item = "wr0343",
                Cost = 2999,
                Size = 33,
                Color = "Салатовый",
                Care = "Ручная деликатная стирка при температуре на более 30",
                Fabric = "100% хлопок",
                Brand = "Stone Island",
                Country = "USA",
                Description = "Повседневный стиль",
                Like = false
            };
            var hudiWhiteImg1 = new ImgInfo { Id = 1, Url = "/img/hudi-white-1.jpg", ProductId = hudiWhite.Id };
            var hudiWhiteImg2 = new ImgInfo { Id = 2, Url = "/img/hudi-white-2.jpg", ProductId = hudiWhite.Id };
            var hudiWhiteImg3 = new ImgInfo { Id = 3, Url = "/img/hudi-white-3.jpg", ProductId = hudiWhite.Id };
            var hudiWhiteImg4 = new ImgInfo { Id = 4, Url = "/img/hudi-white-4.jpg", ProductId = hudiWhite.Id };
            var hudiWhiteImg5 = new ImgInfo { Id = 5, Url = "/img/hudi-white-5.jpg", ProductId = hudiWhite.Id };
            var hudiWhiteImg6 = new ImgInfo { Id = 6, Url = "/img/hudi-white-6.jpg", ProductId = hudiWhite.Id };

            var hudiBlackImg1 = new ImgInfo { Id = 7, Url = "/img/hudi-black-1.jpg", ProductId = hudiBlack.Id };
            var hudiBlackImg2 = new ImgInfo { Id = 8, Url = "/img/hudi-black-2.jpg", ProductId = hudiBlack.Id };
            var hudiBlackImg3 = new ImgInfo { Id = 9, Url = "/img/hudi-black-3.jpg", ProductId = hudiBlack.Id };
            var hudiBlackImg4 = new ImgInfo { Id = 10, Url = "/img/hudi-black-4.jpg", ProductId = hudiBlack.Id };
            var hudiBlackImg5 = new ImgInfo { Id = 11, Url = "/img/hudi-black-5.jpg", ProductId = hudiBlack.Id };
            var hudiBlackImg6 = new ImgInfo { Id = 12, Url = "/img/hudi-black-6.jpg", ProductId = hudiBlack.Id };

            var vestImg1 = new ImgInfo { Id = 13, Url = "/img/vest-1.jpg", ProductId = vest.Id };
            var vestImg2 = new ImgInfo { Id = 14, Url = "/img/vest-2.jpg", ProductId = vest.Id };
            var vestImg3 = new ImgInfo { Id = 15, Url = "/img/vest-3.jpg", ProductId = vest.Id };
            var vestImg4 = new ImgInfo { Id = 16, Url = "/img/vest-4.jpg", ProductId = vest.Id };
            var vestImg5 = new ImgInfo { Id = 17, Url = "/img/vest-5.jpg", ProductId = vest.Id };
            var vestImg6 = new ImgInfo { Id = 18, Url = "/img/vest-6.jpg", ProductId = vest.Id };

            var womanCostumeImg1 = new ImgInfo { Id = 19, Url = "/img/woman-costume-1.jpg", ProductId = womanCostume.Id };
            var womanCostumeImg2 = new ImgInfo { Id = 20, Url = "/img/woman-costume-2.jpg", ProductId = womanCostume.Id };
            var womanCostumeImg3 = new ImgInfo { Id = 21, Url = "/img/woman-costume-3.jpg", ProductId = womanCostume.Id };
            var womanCostumeImg4 = new ImgInfo { Id = 22, Url = "/img/woman-costume-4.jpg", ProductId = womanCostume.Id };
            var womanCostumeImg5 = new ImgInfo { Id = 23, Url = "/img/woman-costume-5.jpg", ProductId = womanCostume.Id };
            var womanCostumeImg6 = new ImgInfo { Id = 24, Url = "/img/woman-costume-6.jpg", ProductId = womanCostume.Id };

            modelBuilder.Entity<ImgInfo>().HasData(new List<ImgInfo>()
            {
                hudiWhiteImg1, hudiWhiteImg2, hudiWhiteImg3, hudiWhiteImg4, hudiWhiteImg5, hudiWhiteImg6,
                hudiBlackImg1, hudiBlackImg2, hudiBlackImg3, hudiBlackImg4, hudiBlackImg5, hudiBlackImg6,
                vestImg1, vestImg2, vestImg3, vestImg4, vestImg5, vestImg6,
                womanCostumeImg1, womanCostumeImg2, womanCostumeImg3, womanCostumeImg4, womanCostumeImg5, womanCostumeImg6
            });
            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                hudiWhite, hudiBlack, vest, womanCostume
            });
        }
    }
}
