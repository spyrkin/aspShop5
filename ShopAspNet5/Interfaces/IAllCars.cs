using ShopAspNet5.Models;
using System.Collections.Generic;

namespace ShopAspNet5.Interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carId);

    }
}
