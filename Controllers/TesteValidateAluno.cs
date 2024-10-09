


using AppAlunos.Models;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiroApp.Controllers;

public class ModelsController : Controller
{
    public IActionResult Index()
    {
        var aluno = new Aluno();

        if(TryValidateModel(aluno))
        {
            return View (aluno);
        }
        return View();
    }
}
