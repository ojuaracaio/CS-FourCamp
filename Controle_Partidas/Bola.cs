using System;

public class Bola
{
	private string cor, material, fabricante;
	private int tamanho, peso;
	private bool isNova;

	public Bola()
	{
	}

	public Bola (string cor, string material, string fabricante, int tamanho, int peso, bool isNova)
    {
		this.cor = cor;
		this.material = material;
		this.fabricante = fabricante;
		this.tamanho = tamanho;
		this.peso = peso;
		this.isNova = isNova;
    }

	public void chutar(int metros)
    {
        Console.WriteLine($"A bola foi chutada {metros} metros de distância.");
    }
}
