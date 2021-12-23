using System;

public class Juiz
{
	public string nome { get; set; }
	public string experiencia { get; set; }
    public string certificacao { get; set; }
	public int altura { get; set; }

	public Juiz()
    {

    }
	public Juiz(string nome, int altura, string experiencia, string certificacao)
	{
		this.nome = nome;
		this.altura = altura;
		this.experiencia = experiencia;
		this.certificacao = certificacao;
	}

	public void imprimeDados()
    {
        Console.WriteLine("Dados do Juiz:");
		Console.WriteLine("nome:", this.nome);
        Console.WriteLine("altura:", this.altura);
		Console.WriteLine("experiência:", this.experiencia);
        Console.WriteLine("certificado pela FIFA?", this.certificacao);
    }


}
