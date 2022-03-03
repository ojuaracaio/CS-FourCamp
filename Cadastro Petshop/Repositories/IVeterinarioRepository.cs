using Cadastro_Petshop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public interface IVeterinarioRepository
    {
        void Cadastrar(Veterinario veterinario);

        void Atualizar(Veterinario veterinario);

        void Excluir(int id);

        Veterinario BuscarPorId(int id);

        List<Veterinario> Listar();

        List<Veterinario> BuscarPor(Expression<Func<Veterinario, bool>> filtro);

        void Salvar();
    }
}
