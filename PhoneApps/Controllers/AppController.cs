using Microsoft.AspNetCore.Mvc;
using PhoneApps.Models;
using System.Collections.Generic;

namespace PhoneApps.Controllers
{
  public class AppController : Controller
  {
    [HttpGet("/app")]
    public ActionResult Index()
    {
      List<App> allApps = App.GetAll();
      return View(allApps);
    }

    [HttpGet("/app/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/app/create/new")]
    public ActionResult Create(string name, string developer, string category, string releaseDate)
    {
      App newApp = new App(name, developer, category, releaseDate);
      newApp.Save();
      return RedirectToAction("Index");
    }

    [HttpGet("/app/{appId}/")]
    public ActionResult Show(int appId)
    {
      App app = App.Find(appId);
      return View(app);
    }

    [HttpPost("/app/delete")]
    public ActionResult DeleteAll()
    {
      App.ClearAll();
      return View();
    }
  }
}