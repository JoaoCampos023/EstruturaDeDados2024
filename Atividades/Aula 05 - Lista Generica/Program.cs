using Aula_05___Lista_Generica;


List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um Numero: ");
    string? numberStr = Console.ReadLine();

    // Validando a entrada do usuario;

    if(!double.TryParse(numberStr, out double number))
    {
        break;
    }

    numbers.Add(number);
    Console.WriteLine($"A media dos valores é {numbers.Average()}");

}
while(true);

// -- Lista de Pessoas;

List<Person> people = new List<Person>();
Person p1 = new Person();
p1.Name = "Joao Vitor";
p1.Age = 22;
p1.Country = CountryEnum.BR;
people.Add(p1);

p1.Name = "Joao Vitor Campos";

people.Add(new Person(){
    Name = "Jake",
    Age = 5,
    Country = CountryEnum.BR,

});

Person p3 = new Person(){
    Name = "Zoe",
    Age = 1,
    Country = CountryEnum.BR,
};
people.Add(p3);

// Formas de percorrer a Lista Generica

foreach(Person p in people)
{
    Console.WriteLine(p.Name);
}

//Modo for Tradicional

for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i].Name);
}

