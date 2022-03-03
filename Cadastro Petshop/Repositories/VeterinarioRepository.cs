using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {
        private Cadastro_PetshopContext _context;
        public void Atualizar(Veterinario veterinario)
        {
            _context.Veterinarios.Update(veterinario);
        }

        public List<Veterinario> BuscarPor(Expression<Func<Veterinario, bool>> filtro)
        {
            return _context.Veterinarios.Include(v => v.ContratoTrabalho).Where(filtro).ToList();
        }

        public Veterinario BuscarPorId(int id)
        {
            return _context.Veterinarios.Include(a => a.ContratoTrabalho).Where(v => v.VeterinarioId == id).FirstOrDefault();
        }

        public void Cadastrar(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
        }

        public void Excluir(int id)
        {
            Veterinario veterinario = _context.Veterinarios.Find(id);
            _context.Remove(veterinario);
        }

        public List<Veterinario> Listar()
        {
            return _context.Veterinarios.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
