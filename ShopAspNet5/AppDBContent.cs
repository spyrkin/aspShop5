using Microsoft.EntityFrameworkCore;
using ShopAspNet5.Models;
using ShopAspNet5.Modelss;

namespace ShopAspNet5
{
    public class AppDBContent : DbContext
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCartItem> ShopCartItem { get; set; }


    }
}
