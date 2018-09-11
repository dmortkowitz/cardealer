using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}