using Aula_08___BubbleSort;

int[] inteiros = [0, 12, 7, 1, 2, 8];

Console.Write('[');
foreach(int i in inteiros)
{
    Console.Write($"{i} ");
}
Console.Write(']');

Aula_08___BubbleSort.BubbleSort.Sort<int>(inteiros);

Console.Write('[');
foreach(int i in inteiros)
{
    Console.Write($"{i} ");
}
Console.Write(']');