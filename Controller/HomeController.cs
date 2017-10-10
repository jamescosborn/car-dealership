using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/car/create")]
    public ActionResult CreateCar()
    {
      string newMakeModel = Request.Form["new-makemodel"];
      string newYear = Request.Form["new-year"];
      string newPrice = Request.Form["new-price"];
      string newMileage = Request.Form["new-mileage"];
      Car newCar = new Car (newMakeModel, newYear, newPrice, newMileage);
      newCar.Save();
      return View(newCar);
    }
    [Route("/CarLotList")]
    public ActionResult CarLotList()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }
    [HttpPost("/CarList/clear")]
    public ActionResult CarListClear()
    {
      Car.ClearAll();
      return View();
    }
  }
}
