using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MyMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        GreetingService greetingMessage = new GreetingService();

        ViewData["GreetingMessage"] = greetingMessage.GetGreetingMessage();

        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }
}
