using BD_Exemplo.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace BD_Exemplo.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context;

        public AnimalController(PetshopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
