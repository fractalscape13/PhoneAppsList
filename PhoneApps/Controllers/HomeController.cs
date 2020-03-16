using Microsoft.AspNetCore.Mvc;

namespace PhoneApp.Controllers
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