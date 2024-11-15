﻿using System.Collections;

// Exemplo de uma agenda telefonica;

Hashtable phoneBook = new Hashtable()
{
    { "Silvio", "49-99830-0705"},
    { "Joao Campos", "49-99918-8470"},
    { "Joao Pedro", "49-99962-3062"}
};

// É possivel adicionar elementos de diversas formas;
// Pelo proprio indice chave inexistente;
phoneBook["Mayara"] = "49-99933-4666";

// Ou pelo ADD();
phoneBook.Add("Lorildes", "49-9802-5849");

// Entre tanto, a tabela Hash verifica se há duplicidade de chave e pode lançar uma Exception;
try
{
    phoneBook.Add("Joao Campos", "49-99918-8470");
}
catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da HashTable;
Console.WriteLine("Agenda telefonica: ");
if(phoneBook.Count == 0)
{
    Console.WriteLine("A agenda esta vazia.");
}
else
{
    foreach(DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    }
}

