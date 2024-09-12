// Basicamente as pulhas trabalham com uma estrutura LIFO - Last In First Out;

/* 

Tres metodos importantes: 

Push () -> Insere um elemento no topo da pilha;
Pop () -> Remove um elemento do topo e o retorna;
Peek () -> Retorna o elemento do topo sem removelo;

*/

// Invertendo as bolas:

Stack<char> carcteres = new Stack<char>();
foreach(char c in "DARCY AD MONTANHA")
{
    carcteres.Push(c);
}

// Desempilhando;

string invertido = string.Empty;
while(carcteres.Count > 0)
{
    invertido += carcteres.Pop();
}

Console.WriteLine(invertido);

/*

ATIVIDADE:

Utilizando o conceito de pilha(stack) com os metodos pop e push escreva um programa que leia uma entrada do usua e identifique se a palavra 
informada é ou não um palindromo.

*/
