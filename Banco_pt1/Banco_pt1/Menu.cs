using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    public class Menu
    {
        public Menu()
        {

        }

        public void ImprimirMenu()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("==============================");
            Console.WriteLine("1-Cadastrar Pessoa");
            Console.WriteLine("2-Transferir Dinheiro");
            Console.WriteLine("3-Depositar Dinheiro");
            Console.WriteLine("4-Dados Cliente");
            Console.WriteLine("5-Finalizar Mês");
            Console.WriteLine("6-Pix");
            Console.WriteLine("7-Sair");
            Console.WriteLine("==============================");
        }

        public bool EscolherConta()
        {
            Console.WriteLine("De qual conta deseja realizar a operação? Digite apenas o número das opções abaixo:");
            Console.WriteLine("1-Conta Corrente");
            Console.WriteLine("2-Conta Poupança");
            string opcao = Console.ReadLine();

            //certifica que a resposta é 1 ou 2
            while (opcao != "1" && opcao != "2")
            {
                Console.WriteLine("Opção inválida. Use apenas '1' ou '2'.");
                opcao = Console.ReadLine();
            }
            if (opcao == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal DecimalValido()
        {
            Console.WriteLine("Insira o valor:");
            string leitura = Console.ReadLine();
            while (true) //checa se é possível converter a entrada para decimal
            {
                try
                {
                    return decimal.Parse(leitura);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Valor inválido. Use apenas números.");
                    leitura = Console.ReadLine();                    
                }
                
            }
        }
    }
}
