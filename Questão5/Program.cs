using System;

class Program
{
	static void Main(string[] args)
	{
		// Solicitar ao usuário que insira a string
		Console.WriteLine("Digite uma frase para inverter seus caracteres:");
		string texto = Console.ReadLine();

		// Inverter a string
		string textoInvertido = InverterString(texto);

		// Exibir o resultado
		Console.WriteLine($"String original: {texto}");
		Console.WriteLine($"String invertida: {textoInvertido}");
	}

	static string InverterString(string texto)
	{
		// Converter a string para um array de caracteres
		char[] caracteres = texto.ToCharArray();

		// Inverter o array de caracteres
		int tamanho = caracteres.Length;
		for (int i = 0; i < tamanho / 2; i++)
		{
			// Trocar o caractere na posição i com o caractere na posição correspondente no final do array
			char temp = caracteres[i];
			caracteres[i] = caracteres[tamanho - 1 - i];
			caracteres[tamanho - 1 - i] = temp;
		}

		// Converter o array de caracteres de volta para uma string
		string textoInvertido = new string(caracteres);

		return textoInvertido;
	}
}
