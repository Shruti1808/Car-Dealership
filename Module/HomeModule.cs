using Nancy;
using CarDealership.Objects;
using System.Collections.Generic;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ => View["add_cars.cshtml"];

       Get["/view_cars"] = _ => {
         List<Car> allCars = Car.GetAll();
         return View["view_cars.cshtml", allCars];
       };

       Post["/sell_cars"] = _ => {
        Car newCar = new Car (Request.Form["make"], Request.Form["price"], Request.Form["year"],Request.Form["color"],Request.Form["mileage"]);
        newCar.Save();
        return View["view_cars.cshtml", Car.GetAll()];
      };
      Post["/cars_cleared"] = _ => {
          Car.ClearAll();
          return View["cars_cleared.cshtml"];
        };
     }
  }
}
