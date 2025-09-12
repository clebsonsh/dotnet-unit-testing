using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;

namespace SimpleApp.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View(Product.GetProducts());
    }
}