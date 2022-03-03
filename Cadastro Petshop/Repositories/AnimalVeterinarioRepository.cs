using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public class AnimalVeterinarioRepository : IAnimalVeterinarioRepository
    {
        private Cadastro_PetshopContext _context;

        public void Atualizar(AnimalVeterinario animalVeterinario)
        {
            _context.AnimaisVeterinarios.Update(animalVeterinario);
        }

        public List<AnimalVeterinario> BuscarPor(Expression<Func<AnimalVeterinario, bool>> filtro)
        {
            return _context.AnimaisVeterinarios.Include(av => av.AnimalVeterinarioId).Where(filtro).ToList();
        }

        public AnimalVeterinario BuscarPorId(int id)
        {
            return _context.AnimaisVeterinarios.Include(a => a.AnimalId).Where(v => v.AnimalVeterinarioId == id).FirstOrDefault();
        }

        public void Cadastrar(AnimalVeterinario animalVeterinario)
        {
            _context.AnimaisVeterinarios.Add(animalVeterinario);
        }

        public void Excluir(int id)
        {
            AnimalVeterinario av = _context.AnimaisVeterinarios.Find(id);
            _context.AnimaisVeterinarios.Remove(av);
        }

        public List<AnimalVeterinario> Listar()
        {
            return _context.AnimaisVeterinarios.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
