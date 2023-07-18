using ShopAspNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAspNet5.ViewModels
{
    public class HomeViewModel {
        public IEnumerable<Car> favCars { get; set; }
    }
}
