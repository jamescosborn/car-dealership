using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
    
  }
}
