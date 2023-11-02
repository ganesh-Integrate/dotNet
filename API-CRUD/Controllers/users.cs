using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers;

public class users : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}