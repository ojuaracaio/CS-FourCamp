using Microsoft.AspNetCore.Mvc;

namespace ExemploEstatico.Controllers
{
    public class LinguagemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
