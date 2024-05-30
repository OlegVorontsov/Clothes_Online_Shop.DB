using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Clothes_Online_Shop.DB.Models
{
    public class User : IdentityUser
    {
        public IList<IdentityRole> Roles { get; set; }
    }
}
