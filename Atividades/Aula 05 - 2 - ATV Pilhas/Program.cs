using System;
using System.Collections.Generic;

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine().Trim();

bool ePalindromo = VerificarPalindromo(palavra);

if (ePalindromo)
{
    Console.WriteLine($"A palavra '{palavra}' é um palíndromo.");
}
else
{
    Console.WriteLine($"A palavra '{palavra}' não é um palíndromo.");
}

static bool VerificarPalindromo(string palavra)
{
    Stack<char> pilha = new Stack<char>();

    foreach (char c in palavra)
    {
        pilha.Push(c);
    }
    
    string palavraInvertida = "";
    while (pilha.Count > 0)
    {
        palavraInvertida += pilha.Pop();
    }

    return palavra.Equals(palavraInvertida, StringComparison.OrdinalIgnoreCase);
}