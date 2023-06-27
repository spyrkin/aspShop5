using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
