using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.Interfaces
{
    interface IAllTV
    {
        IEnumerable<TVModel> allTv { get; }
    }
}
