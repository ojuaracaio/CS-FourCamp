using Cadastro_Petshop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public interface IPlanoRepository
    {
        void Cadastrar(Plano plano);

        void Atualizar(Plano plano);

        void Excluir(int id);

        Plano BuscarPorId(int id);

        List<Plano> Listar();

        List<Plano> BuscarPor(Expression<Func<Plano, bool>> filtro);

        void Salvar();
    }
}
