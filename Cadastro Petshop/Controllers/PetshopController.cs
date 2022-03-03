using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Cadastro_Petshop.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro_Petshop.Controllers
{
    public class PetshopController : Controller
    {
        private Cadastro_PetshopContext _context;
        private IAnimalRepository _animalRepository;
        //private static List<Animal> _animais = new();
        //private static int _id;

        public PetshopController(Cadastro_PetshopContext context, IAnimalRepository animalRepository) 
        {
            _context = context;
            _animalRepository = animalRepository;
        }

        public IActionResult Index() // pag inicial
        {
            ViewBag.quantAnimais = _context.Animais.ToList().Count();
            return View();
        }

        public IActionResult Listar(string nomeBusca) // tabela
        {
            //List<Animal> animais = _context.Animais.Where(a => a.Nome.Contains(nomeBusca) || nomeBusca == null).ToList();
            List<Animal> animais = _animalRepository.BuscarPor(a => a.Nome.Contains(nomeBusca) || nomeBusca == null);
            return View(animais);
        }
        
        [HttpGet]
        public IActionResult Cadastrar() // forms
        {
            CarregarPlanos();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Animal animal)
        {
            TempData["msg"] = $"O pet {animal.Nome} foi cadastrado com sucesso! 😀";
            
            _animalRepository.Cadastrar(animal);
            _animalRepository.Salvar();

            //animal.Id = _id++;
            //_animais.Add(animal);
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            Animal animal = _animalRepository.BuscarPorId(Id);
            //int index = _animais.FindIndex(x => x.Id == Id);
            //TempData["Id"] = index;
            return View(animal);
        }

        [HttpPost]
        public IActionResult Editar(Animal animal)
        {
            _animalRepository.Atualizar(animal);
            _animalRepository.Salvar();


            //_animais[(int)TempData["Id"]] = animal;
            TempData["msg"] = $"O pet {animal.Nome} foi editado com sucesso! 😀";
            return RedirectToAction("Listar");
        }

        public IActionResult Excluir(int id)
        {
            _animalRepository.Excluir(id);
            _animalRepository.Salvar();

            //int index = _animais.FindIndex(x => x.Id == id);
            TempData["msg"] = $"O pet foi excluído com sucesso! 😀";
            //_animais.RemoveAt(index);
            return RedirectToAction("Listar");
        }

        public void CarregarPlanos()
        {
            List<Plano> planos = _context.Planos.OrderBy(p => p.Nome).ToList();
            ViewBag.planos = new SelectList(planos, "PlanoId", "Nome");     
        }
    }
}
