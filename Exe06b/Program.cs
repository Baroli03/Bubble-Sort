using System.Collections.Concurrent;
using System.Numerics;
using System;


Random r = new Random();

int[] vetor = new int[100];
int i = 0;
while (i < vetor.Length) {
    vetor[i] = r.Next(100);
    Console.Write("(" + (i + 1) + "°) " + vetor[i] + ", ");
    i++;
}
Array.Sort(vetor);

Console.Write("\n \n----------------------------------------------------------------- \n\n");
for (int j = 0; j < vetor.Length; j++) {
    Console.Write("(" + (j + 1) + "°) " + vetor[j] + ", ");
}
