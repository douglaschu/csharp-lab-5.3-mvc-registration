using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_coffeeshop_registration.Models;

namespace mvc_coffeeshop_registration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }

    public IActionResult Result(User u)
    {
        return View(u);
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

