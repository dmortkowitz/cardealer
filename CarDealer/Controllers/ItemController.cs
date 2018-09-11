using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers 
{
  public class ItemsController : Controller 
  {

    [HttpGet("/items")]
    public ActionResult Index() 
    {
      List<Car> allCars = new List<Car> {};
      return View(allCars);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm() 
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create() 
    {
      Car newCar = new Car(Request.Form["new-item"]);
      newCar.Save();
      string[] allCars = newCar.ResultsList(); 
      return View("Index", allCars);
    }
  }
}