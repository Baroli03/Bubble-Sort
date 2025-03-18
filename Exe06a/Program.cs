using System;

class Program
{
    static void Main()
    {
        Random r = new Random();

        int[] vetor = new int[100];
        int i = 0;
        int totvezes = 0;

        Console.WriteLine("Initial array:");
        while (i < vetor.Length)
        {
            vetor[i] = r.Next(100); 
            Console.Write("(" + (i + 1) + "°) " + vetor[i] + ", ");
            i++;
        }

        bool condicao;
        do
        {
            condicao = false;
            int atual = 0;
            while (atual < vetor.Length - 1)
            {
                if (vetor[atual] > vetor[atual + 1])
                {
                    int aux = vetor[atual];
                    vetor[atual] = vetor[atual + 1];
                    vetor[atual + 1] = aux;
                    condicao = true;
                }
                atual++;
            }
            totvezes++; 
        } while (condicao); 


        Console.WriteLine("\nSorted array:");
        for (int j = 0; j < vetor.Length; j++)
        {
            Console.Write("(" + (j + 1) + "°) " + vetor[j] + ", ");
        }

        Console.WriteLine("\n\nTotal de iterações: " + totvezes);
    }
}
