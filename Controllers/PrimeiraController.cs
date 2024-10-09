using Microsoft.AspNetCore.Mvc;

namespace PrimeiroApp.Controllers;

public class TesteController : Controller
{

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult Details(int id)
    {
        return View();
    }

    public ActionResult Create()
    {
        return View();
    }


}