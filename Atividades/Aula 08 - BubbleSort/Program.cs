using Aula_08___BubbleSort;

int[] ints = [0, 12, 7, 1, 2, 8];

Aula_08___BubbleSort.BubbleSort.Print(ints, 100);
Console.WriteLine("Sorted with Bubble: ");

Aula_08___BubbleSort.BubbleSort.Sort<int>(ints);
Aula_08___BubbleSort.BubbleSort.Print(ints, 100);

Console.WriteLine("Char Test");
char[] chars = ['x', 'z', 'b', 'c', 'a'];

Aula_08___BubbleSort.BubbleSort.Print(chars, 100);

Aula_08___BubbleSort.BubbleSort.Sort(chars);
Aula_08___BubbleSort.BubbleSort.Print(chars, 100);