using Banco_pt1.Exception;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    public class Pix:ILeitura,IGravacao
    {
        public Dictionary<string, TipoChavePix> ChavesCadastradas { get; set; }
        public DateTime Data { get; set; }
        public bool IsAtivado { get; set; }
        public Conta Conta { get; set; }
        public List<string> NumeroContasPix = new List<string>();
        public Pix(Conta c)
        {
            Conta = c;
            ChavesCadastradas = new Dictionary<string,TipoChavePix>();
        }

        public void AtivarChave()
        {
            IsAtivado = true;
            Data = DateTime.Now;
        }

        public string ConverterDados(Dictionary<string, TipoChavePix> dict)
        {
            string final = "Chave;Tipo;Numero Conta\n"; //cabeçalho
            int cont = 0;
            foreach (KeyValuePair<string, TipoChavePix> item in dict)
            {
                final += $"{item.Key};{item.Value};{NumeroContasPix[cont]}\n";
                cont++;
            }
            return final;
        }

        public void Salvar(string c, string v)
        {
            using StreamWriter sw = new(c);
            sw.Write(v);
        }

        public string[] Decodificar(string c)
        {
            return c.Split(';');
        }

        public string CarregarDados(string s)
        {
            using StreamReader sr = new(s);
            sr.ReadLine(); //desconsidera o cabeçalho
            string final = string.Empty;
            while (!sr.EndOfStream)
            {
                final += sr.ReadLine() + ";";
            }
            return final;
        }

        public void CarregarDicionario(string[] c)
        {
            for (int i = 0; i < c.Length-1; i+=3) 
            {
                switch(c[i+1])
                {
                    case "CPF":
                        ChavesCadastradas.Add(c[i], TipoChavePix.CPF);
                        NumeroContasPix.Add(c[i + 2]);
                        break;
                    case "Telefone":
                        ChavesCadastradas.Add(c[i], TipoChavePix.Telefone);
                        NumeroContasPix.Add(c[i + 2]);
                        break;
                    case "Email":
                        ChavesCadastradas.Add(c[i], TipoChavePix.Email);
                        NumeroContasPix.Add(c[i + 2]);
                        break;
                    case "Aleatório":
                        ChavesCadastradas.Add(c[i], TipoChavePix.Aleatório);
                        NumeroContasPix.Add(c[i + 2]);
                        break;
                    default:
                        break;
                      //  throw new Exception("Opção invalida, tente novamente.");
                }
                //ChavesCadastradas.Add(c[i], TipoChavePix.c[i + 1]);
            }
        }

        public void ImprimirChavesCadastradas()
        {
            int cont = 0;
            foreach (KeyValuePair<string, TipoChavePix> item in ChavesCadastradas)
            {
                Console.WriteLine($"Chave: {item.Key} | Tipo: {item.Value} | Conta: {NumeroContasPix[cont]}");
                cont++;
            }
        }

        public bool AdicionarChave(string chave, TipoChavePix valor)
        {
            if (ChavesCadastradas.ContainsKey(chave))
            {
                throw new PixException("Erro! A chave já foi cadastrada.");
            }
            else
            {
                ChavesCadastradas.Add(chave, valor);
                NumeroContasPix.Add(Conta.Numero);
                return true;
            }
        }

        public TipoChavePix TipoChavePixValida()
        {
            Console.WriteLine("Qual o Tipo da Chave Pix?");
            Console.WriteLine("1-CPF");
            Console.WriteLine("2-Telefone");
            Console.WriteLine("3-Email");
            Console.WriteLine("4-Aleatória");
            Console.WriteLine("Insira a opcao:");
            string opcao = Console.ReadLine();

            while(true)
            {
                switch(opcao)
                {
                    case "1":
                        return TipoChavePix.CPF;
                    case "2":
                        return TipoChavePix.Telefone;
                    case "3":
                        return TipoChavePix.Email;
                    case "4":
                        return TipoChavePix.Aleatório;
                    default:
                        Console.WriteLine("Opção inválida. Use números de 1 a 4.");
                        opcao = Console.ReadLine();
                        break;
                }
            }
        }

        public string EmailValido()
        {
            Console.WriteLine("Digite o Email:");
            string email = Console.ReadLine();

            while (!email.Contains('@') || !email.Contains(".com"))
            {
                Console.WriteLine("Email inválido. Use o formato xxxxxx@xxxx.com");
                email = Console.ReadLine();
            }
            return email;
        }

        public void CriarChave(TipoChavePix tipo)
        {
            try
            {
                switch (tipo)
                {
                    case TipoChavePix.CPF:
                        AdicionarChave(CPFValido(), tipo);
                        break;
                    case TipoChavePix.Email:
                        AdicionarChave(EmailValido(), tipo);
                        break;
                    case TipoChavePix.Telefone:
                        AdicionarChave(TelefoneValido(), tipo);
                        break;
                    case TipoChavePix.Aleatório:
                        AdicionarChave(ChaveAleatoria(), tipo);
                        break;
                    default:
                        break;
                }
            }
            catch (PixException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public string ChaveAleatoria()
        {
            string chave = $"{HexAleatorio(8)}-{HexAleatorio(4)}-{HexAleatorio(4)}-{HexAleatorio(4)}-{HexAleatorio(12)}";
            Console.WriteLine($"Chave aleatória {chave} criada com sucesso!");
            return chave;
        }

        public string HexAleatorio(int tamanho)
        {
            Random r = new Random();
            string Hex = "0123456789abcdef";
            string final = string.Empty;
            for(int i = 0; i < tamanho; i++)
            {
                final+=Hex[r.Next(Hex.Length)];
            }
            return final;
        }

        public string CPFValido()
        {
            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();

            while (!(cpf.Length==11 && cpf.All(Char.IsNumber)))
            {
                Console.WriteLine("CPF inválido. Use apenas 11 números sem pontos ou traços.");
                cpf = Console.ReadLine();
            }
            return cpf;
        }

        public string TelefoneValido()
        {
            Console.WriteLine("Digite o Telefone:");
            string telefone = Console.ReadLine();

            while (!(telefone.Length == 11 && telefone.All(Char.IsNumber)))
            {
                Console.WriteLine("Telefone inválido. Use apenas 11 números sem pontos ou traços.");
                telefone = Console.ReadLine();
            }
            return telefone;
        }

        public void Menu()
        {
            Console.WriteLine("1-Chaves Salvas");
            Console.WriteLine("2-Criar Nova Chave\n");

            Console.WriteLine("Insira a opção:");
            string opcao = Console.ReadLine();

            while(!(opcao=="1") && !(opcao=="2"))
            {
                Console.WriteLine("Opção inválida. Digite apenas (1) ou (2).");
            }

            switch (opcao)
            {
                case "1":
                    ImprimirChavesCadastradas();
                    break;
                case "2":
                    TipoChavePix tipo = TipoChavePixValida();
                    CriarChave(tipo);

                    break;
            }
        }
    }
}
