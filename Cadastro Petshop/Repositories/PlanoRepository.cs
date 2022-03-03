using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public class PlanoRepository : IPlanoRepository
    {
        private Cadastro_PetshopContext _context;

        public void Atualizar(Plano plano)
        {
            _context.Planos.Update(plano);
        }

        public List<Plano> BuscarPor(Expression<Func<Plano, bool>> filtro)
        {
            return _context.Planos.Include(ct => ct.PlanoId).Where(filtro).ToList();
        }

        public Plano BuscarPorId(int id)
        {
            return _context.Planos.Include(ct => ct.PlanoId).Where(ct => ct.PlanoId == id).FirstOrDefault();
        }

        public void Cadastrar(Plano plano)
        {
            _context.Planos.Add(plano);
        }

        public void Excluir(int id)
        {
            Plano plano = _context.Planos.Find(id);
            _context.Planos.Remove(plano);
        }

        public List<Plano> Listar()
        {
            return _context.Planos.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
