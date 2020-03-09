using Microsoft.AspNetCore.Mvc;

namespace DinoPark.Controllers
{
  public class HomeController : Controller
  {
    [Route("/dinos")]
    public string Dinos() { return "Show list of dinos..."; }

    [Route("/fight")]
    public string Fight() { return "Fight two dinos..."; }

    [Route("/")]
    public ActionResult HomePage() { return View(); }
  }
}