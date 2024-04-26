using BlazorOnMvc.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;
using V = BlazorOnMvc.Views.Home;

namespace BlazorOnMvc.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController( ILogger<HomeController> logger )
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(
            "RazorPageBase",
            new RazorPageBaseViewModel<V.Index>("this is param!") );
    }
}
