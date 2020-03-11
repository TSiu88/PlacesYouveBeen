using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index() { return View(); }
  }
}