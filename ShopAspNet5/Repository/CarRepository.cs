using Microsoft.EntityFrameworkCore;
using ShopAspNet5.Interfaces;
using ShopAspNet5.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopAspNet5.Repository
{
    public class CarRepository : IAllCars
    {

        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        //Include это типа связанные данные
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);


        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);
    }
}
