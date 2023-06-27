using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.Interfaces
{
    interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);

    }
}
