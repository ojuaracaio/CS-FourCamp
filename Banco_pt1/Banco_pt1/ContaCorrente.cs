using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    public class ContaCorrente : Conta
    {
        decimal taxaManutencao;
        public ContaCorrente(string numeroConta, Cliente clienteConta, decimal taxa)
        {
            Saldo = 0;
            Numero = numeroConta;
            Cliente = clienteConta;
            taxaManutencao = taxa;
            atualizarTipo();

        }

        public void DescontarTaxa()
        {
            Saldo -= taxaManutencao;
            Console.WriteLine("Taxa de manutenção descontada.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Novo saldo na conta corrente: R${string.Format("{0:0.00}", Saldo)}");
            atualizarTipo();
        }

        public override void imprimirDados()
        {
            atualizarTipo();// certeza que o tipo correto será mostrado
            Console.WriteLine();
            Console.WriteLine("================= CONTA CORRENTE =================");
            //nome e cpf
            Console.WriteLine($"Cliente: {Cliente.Nome} / CPF: {Cliente.Cpf}");
            //data de nascimento
            Console.WriteLine($"Data de Nascimento: {Cliente.DataNascimento.ToShortDateString()}");
            //numero
            Console.WriteLine($"Número: {Numero}");
            //saldo
            Console.WriteLine($"Saldo: R${string.Format("{0:0.00}", Saldo)}");
            //tipo
            Console.WriteLine($"Tipo da Conta: {Cliente.Tipo}");
            Console.WriteLine("========================================");
            Console.WriteLine();

        }
    }
}
