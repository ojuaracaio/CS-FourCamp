using Banco_pt1.Exception;
using System;
using System.Linq;

namespace Banco_pt1 
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string opcao;//, leitura;
            int NumeroConta = 111;
            //decimal deposito, transferencia;
            //Cliente cliente1;
            ContaCorrente conta1;
            ContaPoupanca conta2;
            Menu menu = new Menu();
            const decimal TAXAMANUTENCAO = 5.00m;
            const float TAXARENDIMENTO = 0.05f;
            const int TEMPOANIMACAO = 1000;
            //const int IDADEMINIMA = 16;
            //const int IDADEMAXIMA = 120;
            //const int ANOATUAL = 2022;


            //FUNÇÕES
            static void animacao()
            {
                for (int i = 0; i < 3; i++)
                {
                    System.Threading.Thread.Sleep(TEMPOANIMACAO);
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==============================\nBem-vindo ao sistema do 3Bank\n==============================\n");

            Cliente cliente1 = new Cliente("Caio Araujo", "12345678999", new DateTime(1998, 12, 08));
            
            conta1 = new ContaCorrente(NumeroConta.ToString(), cliente1, TAXAMANUTENCAO);
            conta2 = new ContaPoupanca(NumeroConta.ToString(), cliente1, TAXARENDIMENTO);

            Pix pix = new Pix(conta1);
            pix.AtivarChave();
            pix.CarregarDicionario(pix.Decodificar(pix.CarregarDados("../../../ChavesPix.csv")));
            //pix.AdicionarChave("22222222222",TipoChavePix.CPF);
            //pix.ImprimirChavesCadastradas();
            

            //Laço principal
            while (true)
            {
                //Console.Clear();

                menu.ImprimirMenu();

                Console.Write("Digite o número da opção desejada: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        cliente1.AtualizarCliente();

                        NumeroConta++;
                        pix.Conta.Numero = NumeroConta.ToString();
                        conta1 = new ContaCorrente(NumeroConta.ToString(), cliente1, TAXAMANUTENCAO);
                        conta2 = new ContaPoupanca(NumeroConta.ToString(), cliente1, TAXARENDIMENTO);
                        break;


                    case "2":
                        try
                        {
                            if (menu.EscolherConta()) // conta corrente
                            {
                                conta1.transferir(menu.DecimalValido());
                            }
                            else // conta poupança
                            {
                                conta2.transferir(menu.DecimalValido());
                            }
                        }
                        catch (TransferException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        
                        
                        break;
                    case "3":
                        
                        if (menu.EscolherConta()) // conta corrente
                        {
                            conta1.depositar(menu.DecimalValido());
                        }
                        else // conta poupança
                        {
                            conta2.depositar(menu.DecimalValido());
                        }
                        break;
                    case "4":
                        if (menu.EscolherConta()) // conta corrente
                        {
                            conta1.imprimirDados();
                        }
                        else // conta poupança
                        {
                            conta2.imprimirDados();
                        }
                        break;

                    case "5":
                        //finalizar mês
                        Console.Write("Finalizando o mês");
                        animacao();
                        
                        Console.Write("Descontando taxa de manutenção");
                        animacao();

                        conta1.DescontarTaxa();
                        Console.Write("Adicionando rendimentos");
                        animacao();

                        conta2.AdicionarRendimento();
                        Console.WriteLine("Mês finalizado com sucesso!");
                        break;

                    case "6":
                        pix.Menu();
                        break;

                    case "7":
                        Console.WriteLine("Saindo do programa...");
                        pix.Salvar("../../../ChavesPix.csv", pix.ConverterDados(pix.ChavesCadastradas));
                        return; //Sai do programa
                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 7.");
                        break;
                }
            }
        }
    }
}