using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Petshop.Controllers
{
    public class AnimalVeterinarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
