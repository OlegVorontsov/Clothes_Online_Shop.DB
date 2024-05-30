using Clothes_Online_Shop;
using Clothes_Online_Shop.DB.Models;
using Microsoft.AspNetCore.Identity;

namespace Clothes_Online_Shop.DB
{
    public class IdentityInitializer
    {
        public static void Initialize(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var adminEmail = "admin@gmail.com";
            var password = "qwerHELP1986!";
            if (roleManager.FindByNameAsync(ShopUser.AdminRoleName).Result == null)
            {
                roleManager.CreateAsync(new IdentityRole(ShopUser.AdminRoleName)).Wait();
            }
            if (roleManager.FindByNameAsync(ShopUser.UserRoleName).Result == null)
            {
                roleManager.CreateAsync(new IdentityRole(ShopUser.UserRoleName)).Wait();
            }
            if (userManager.FindByNameAsync(adminEmail).Result == null)
            {
                var admin = new User { Email = adminEmail, UserName = adminEmail };
                var result = userManager.CreateAsync(admin, password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(admin, ShopUser.AdminRoleName).Wait();
                }
            }
        }
    }
}