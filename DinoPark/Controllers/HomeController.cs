using Microsoft.AspNetCore.Mvc;
using DinoPark.Models;

namespace DinoPark.Controllers
{
  public class HomeController : Controller
  {
    [Route("/dinos")]
    public string Dinos() { return "Show list of dinos..."; }

    [Route("/fight")]
    public string Fight() { return "Fight two dinos..."; }

    [Route("/")]
    public ActionResult HomePage() 
    {
      Park newPark = new Park();
      Dino rex = new Dino("Rex", "T-Rex", 42);
      newPark.AddDino(rex);
      return View(newPark);
    }
  }
}