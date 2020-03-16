using Microsoft.AspNetCore.Mvc;

namespace PhoneApps.Controllers
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