using ShopAspNet5.Interfaces;
using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.Repository
{
    public class CategoryRepository : ICarsCategory
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
