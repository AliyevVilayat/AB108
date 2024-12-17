using Microsoft.AspNetCore.Mvc;

namespace Project.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
