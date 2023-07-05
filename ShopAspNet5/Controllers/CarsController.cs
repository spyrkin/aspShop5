using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopAspNet5.Interfaces;
using ShopAspNet5.ViewModels;

namespace ShopAspNet5.Controllers
{
    public class CarsController :Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
            //return View(obj);
            //можно просто создать ViewBag - он закинется в шаблон сам
            //можно осздатить обьект и закинуть в View(obj) - этот обьект потом достанется как @model IEnnumarable<Car>

            //@using ShopAspNet5.ViewModels
            //@model CarsListViewModel
            // а можно их и не вызывать - само подхватить походу чет новое

        }


    }
}
