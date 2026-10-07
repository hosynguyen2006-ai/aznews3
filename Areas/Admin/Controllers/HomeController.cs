using Microsoft.AspNetCore.Mvc;

namespace aznews.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}