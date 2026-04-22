using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Graciel17.Models;

namespace Graciel17.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new PrismModel());
    }

    [HttpPost]
    public IActionResult Index(PrismModel model)
    {
        if (ModelState.IsValid)
        {
            // Calculations are done in the model properties
            return View(model);
        }
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
