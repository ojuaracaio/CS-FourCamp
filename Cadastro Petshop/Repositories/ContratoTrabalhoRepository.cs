using Cadastro_Petshop.Models;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public class ContratoTrabalhoRepository : IContratoTrabalhoRepository
    {
        private Cadastro_PetshopContext _context;


        public void Atualizar(ContratoTrabalho contratoTrabalho)
        {
            _context.ContratosTrabalhos.Update(contratoTrabalho);
        }

        public List<ContratoTrabalho> BuscarPor(Expression<Func<ContratoTrabalho, bool>> filtro)
        {
            return _context.ContratosTrabalhos.Include(ct => ct.ContratoTrabalhoId).Where(filtro).ToList();
        }

        public ContratoTrabalho BuscarPorId(int id)
        {
            return _context.ContratosTrabalhos.Include(ct => ct.ContratoTrabalhoId).Where(ct => ct.ContratoTrabalhoId == id).FirstOrDefault();
        }

        public void Cadastrar(ContratoTrabalho contratoTrabalho)
        {
            _context.ContratosTrabalhos.Add(contratoTrabalho);
        }

        public void Excluir(int id)
        {
            ContratoTrabalho ct = _context.ContratosTrabalhos.Find(id);
            _context.ContratosTrabalhos.Remove(ct);
        }

        public List<ContratoTrabalho> Listar()
        {
            return _context.ContratosTrabalhos.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
