using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.ViewModels
{
    public class CarsListViewModel
    {

        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }

    }
}
