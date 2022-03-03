using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    public class ContaPoupanca : Conta
    {
        float taxaRendimento;
        public ContaPoupanca(string numeroConta, Cliente clienteConta, float rendimento)
        {
            Saldo = 0;
            Numero = numeroConta;
            Cliente = clienteConta;
            taxaRendimento = rendimento;
            atualizarTipo();
        }

        public void AdicionarRendimento()
        {
            Saldo *= (1 + (decimal)taxaRendimento);
            Console.WriteLine("Rendimento adicionado.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Novo saldo na conta poupança: R${string.Format("{0:0.00}", Saldo)}");
            atualizarTipo();
        }

        public override void imprimirDados()
        {
            atualizarTipo();// certeza que o tipo correto será mostrado

            Console.WriteLine();
            Console.WriteLine("================= CONTA POUPANÇA =================");
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
