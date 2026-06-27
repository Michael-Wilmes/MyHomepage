using Microsoft.AspNetCore.Mvc;

namespace MichaelWilmesMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
