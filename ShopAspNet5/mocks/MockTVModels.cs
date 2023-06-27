using ShopAspNet5.Interfaces;
using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.mocks
{
    public class MockTVModels : IAllTV
    {
        public IEnumerable<TVModel> allTv
        {
            get
            {
                return new List<TVModel> {
                new TVModel { model = "Samsung", price = 2500, diagonal = 40 }
            };
            }
        }
    }
}
