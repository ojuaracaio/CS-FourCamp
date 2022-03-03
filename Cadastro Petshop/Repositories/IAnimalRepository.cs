using Cadastro_Petshop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadastro_Petshop.Repositories
{
    public interface IAnimalRepository
    {
        void Cadastrar(Animal animal);

        void Atualizar(Animal animal);

        void Excluir(int id);

        Animal BuscarPorId(int id);

        List<Animal> Listar();

        List<Animal> BuscarPor(Expression<Func<Animal, bool>> filtro);

        void Salvar();
    }
}
