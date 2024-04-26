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

    public async ValueTask<IActionResult> Index()
    {
        return await this.RazorComponent<V.Index>();
    }
}
