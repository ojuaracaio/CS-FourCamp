using Cadastro_Petshop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public interface IAnimalVeterinarioRepository
    {
        void Cadastrar(AnimalVeterinario animalVeterinario);

        void Atualizar(AnimalVeterinario animalVeterinario);

        void Excluir(int id);

        AnimalVeterinario BuscarPorId(int id);

        List<AnimalVeterinario> Listar();

        List<AnimalVeterinario> BuscarPor(Expression<Func<AnimalVeterinario, bool>> filtro);

        void Salvar();
    }
}
