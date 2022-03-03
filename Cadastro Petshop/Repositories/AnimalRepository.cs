using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private Cadastro_PetshopContext _context;
        public AnimalRepository(Cadastro_PetshopContext context)
        {
            _context = context;
        }


        public List<Animal> BuscarPor(Expression<Func<Animal, bool>> filtro)
        {
            return _context.Animais.Include(a => a.Plano).Where(filtro).ToList();
        }

        public Animal BuscarPorId(int id)
        {
            return _context.Animais.Include(a => a.Plano).Where(a => a.AnimalID == id).FirstOrDefault();
        }

        public void Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal);
        }

        public void Atualizar(Animal animal)
        {
            _context.Animais.Update(animal);
        }

        public void Excluir(int id)
        {
            Animal animal = _context.Animais.Find(id);
            _context.Animais.Remove(animal);
        }

        public List<Animal> Listar()
        {
            return _context.Animais.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
