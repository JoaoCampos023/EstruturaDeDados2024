using Aula_07___Dicionario;

// Diferente da tabela Hash, o Dictionery nos permite especificar o tipo de dado que sera utilizado nos pares;
// Key -> Value;
// Isso nos fornece uma estrutura fortemente tipada;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    {"Chave 1","valor 1"},
    {"Chave 2","valor 2"},
};

// Obter valor do Dictionery
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch(Exception ex)
{
    Console.WriteLine("Erro ao obter valor Chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar para evitar erros e prejuizos de execução;

if( dictionary.ContainsKey("Chave 2") )
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

// Outra forma de obter o valor e evitar erros;
dictionary.TryGetValue("Chave 4", out string? valor);
if( valor is not null)
{
    Console.WriteLine($"Chave 4: {valor}");
}

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "Valor 0";

// Percorrer o dicionario;
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}

// Utilizando Tipos Abstrator de dados com dicionário 

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(1, new Pessoa(){
    Id = 0, 
    BirthDate = new DateTime(2002, 03, 23),
    Name = "Joao Campos",
    
    }
);

dicPessoa.Add(2, new Pessoa(){
    Id = 0, 
    BirthDate = new DateTime(2019, 07, 20),
    Name = "Mayara",
    }
);

foreach(KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}