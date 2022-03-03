using Banco_pt1.Exception;
using System;

public abstract class Conta
{
    public string Numero { get; set; }
    private protected decimal Saldo { get; set; }
    public Cliente Cliente { get; set; }

    public Conta()
    {

    }

    public void atualizarTipo()
    {
        if (Saldo < 5000)
        {
            //comum
            Cliente.Tipo = TipoCliente.Comum;
        }
        else if (Saldo < 15000)
        {
            //super
            Cliente.Tipo = TipoCliente.Super;
        }
        else
        {
            //premium
            Cliente.Tipo = TipoCliente.Premium;
        }
    }

    public abstract void imprimirDados();

    public void depositar(decimal quantia)
    {
        Saldo += quantia;
        Console.WriteLine($"O saldo após o depósito é de R${string.Format("{0:0.00}", Saldo)}");
        atualizarTipo();
    }

    public void transferir(decimal quantia)
    {
        if (quantia <= 0)
        {
            throw new TransferException("Erro! Só é possível transferir valores maiores que R$ 0.");
        } else if(quantia <= Saldo)
        {
            Console.WriteLine("Transferência realizada com sucesso!");
            Saldo -= quantia;
        } else
        {
            throw new TransferException("Erro! Saldo Insuficiente.");
        }
        Console.WriteLine($"Saldo atual: {string.Format("{0:0.00}", Saldo)}");
        atualizarTipo();
    }
}