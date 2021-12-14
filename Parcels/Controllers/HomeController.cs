using Parcels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult AddingParcel(IFormCollection input)
    {
      Parcel addedParcel = new Parcel(input["width"], input["height"], input["depth"], input["weight"]);
      return View("Index", addedParcel);
    }
  }
}