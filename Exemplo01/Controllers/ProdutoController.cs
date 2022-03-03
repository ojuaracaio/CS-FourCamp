using Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Exemplo01.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _produtos = new();
        public IActionResult Index()
        {
            ViewBag.produtos = _produtos;
            return View();
        }


        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
     
            TempData["msg"] = "Produto cadastrado com sucesso!";
            _produtos.Add(produto);

            return RedirectToAction("Index");
        }
    }
}
