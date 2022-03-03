using Cadastro_Petshop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public interface IContratoTrabalhoRepository
    {
        void Cadastrar(ContratoTrabalho contratoTrabalho);

        void Atualizar(ContratoTrabalho contratoTrabalho);

        void Excluir(int id);

        ContratoTrabalho BuscarPorId(int id);

        List<ContratoTrabalho> Listar();

        List<ContratoTrabalho> BuscarPor(Expression<Func<ContratoTrabalho, bool>> filtro);

        void Salvar();
    }
}
