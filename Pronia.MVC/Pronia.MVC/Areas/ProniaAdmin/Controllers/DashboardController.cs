using Microsoft.AspNetCore.Mvc;
using Pronia.BL.Services.Abstractions;

namespace Pronia.MVC.Areas.ProniaAdmin.Controllers;

[Area("ProniaAdmin")]
public class DashboardController : Controller
{
    private readonly ISliderItemService _sliderItemService;

    public DashboardController(ISliderItemService sliderItemService)
    {
        _sliderItemService = sliderItemService;
    }

    public IActionResult Index(int? id)
    {

        return View(id);
    }
}
