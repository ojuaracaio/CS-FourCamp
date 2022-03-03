using System;
using System.Linq;

public class Cliente
{
    //declaração de atributos
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public TipoCliente Tipo { get; set; }
    public DateTime DataNascimento { get; set; }

    //construtor
    public Cliente(string entradaNome, string entradaCpf, DateTime entradaNascimento)
    {
        Nome = entradaNome;
        Cpf = entradaCpf;
        DataNascimento = entradaNascimento;
        //Console.WriteLine($"O cliente {entradaNome} foi cadastrado com sucesso!");
    }

    public Cliente()
    {

    }

    public void AtualizarCliente()
    {
        //int ano, mes, dia;
        Console.WriteLine("Digite o nome do cliente:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o cpf do cliente (sem pontuação):");
        string cpf = Console.ReadLine();

        while (!ECpfValido(cpf)) // cpf.All(Char.IsDigit)   !ulong.TryParse(cpf,out _)
        {
            Console.WriteLine("Número de CPF inválido, digite novamente.");
            cpf = Console.ReadLine();
        }

        Console.WriteLine("Digite a data de nascimento (dd/mm/aaaa) :");
        string data = Console.ReadLine();

        while(!EDataValida(data))
        {
            Console.WriteLine("Data de nascimento inválida. Use o formato dd/mm/aaaa.");
            data = Console.ReadLine();
        }

        Nome = nome;
        Cpf = cpf;
        DataNascimento = GerarData(data);

        Console.WriteLine();
    }

    public bool ECpfValido(string cpf)
    {
        if (cpf.Length == 11 && cpf.All(Char.IsNumber))
        {
            return true;
        } else
        {
            return false;
        }
    }

    public bool EDataValida(string entrada)
    {
        string[] valores = entrada.Split('/');
        try
        {
            new DateTime(int.Parse(valores[2]), int.Parse(valores[1]), int.Parse(valores[0]));
        }
        catch (Exception)
        {
            return false;
        }
        return true;

    }

    public DateTime GerarData(string entrada)
    {
        string[] valores = entrada.Split('/');
        return new DateTime(int.Parse(valores[2]), int.Parse(valores[1]), int.Parse(valores[0]));
    }
}