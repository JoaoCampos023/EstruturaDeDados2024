﻿// JeggedArray é tambem conhecido como um vetor de vetores;

int [][] numbers = new int[5][];

// Nesse caso [][] indica que é um vetor de vetor, neste exemplo um vetor de 4 posições contendo tam. indefinido;

numbers[0] = new int[] {1,2,3};
numbers[1] = new int[] {4,3,2,1,0};
numbers[2] = new int[] {1,2,0};
numbers[3] = new int[] {57};
numbers[4] = null!;

// Para obter valor de JaggedArray;

int valor = numbers[0][2];
Console.WriteLine(valor);

// Para atribuir valor em JaggedArray;

numbers[1][2] = 0;
Console.WriteLine( numbers[1][2] );
