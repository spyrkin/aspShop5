using ShopAspNet5.Interfaces;
using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего згорания" }
                };
            }
        }
    }
}
