using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopContext : IdentityDbContext<ShopUser>
    {
        public ShopContext() : base("ShopConnectionString")
        {

        }


        public static ShopContext Create()
        {
            return new ShopContext();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
