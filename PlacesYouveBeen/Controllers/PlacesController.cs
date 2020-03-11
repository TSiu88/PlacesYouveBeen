using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/places")]
    public ActionResult Create(string param) 
    { 
      Item myItem = new Item(param);
      return View(); 
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show() 
    { 
      return View(); 
    }
  }
}