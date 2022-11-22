class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, seja bem vindo!\nEsse projeto foi feito para avaliacao da sa6 do curso de desenvolvimento de sistemas");
        Menu();
    }

    private static void Menu()
    {
        int q;
        int[] lista_de_numeros;
        Console.WriteLine("Digite a quantidade de valores que serão adicionados:");
        q = int.Parse(Console.ReadLine());
        lista_de_numeros = new int[q];
        for (int i = 0; i < q; i++)
        {
            Console.WriteLine($"Digite o valor que será adicionado a posicao {i + 1}:");
            lista_de_numeros[i] = int.Parse(Console.ReadLine());
        }
        int[] n = new int[lista_de_numeros.Length];



        MergeSort(lista_de_numeros, n, 0, lista_de_numeros.Length-1);
        Console.WriteLine(String.Join(" ", lista_de_numeros));
    }

    private static void MergeSort(int[] lista_de_numeros, int[] n, int inicio, int fim)
    {
        if(inicio < fim)
        {
             int meio = (inicio + fim)/ 2;
             MergeSort(lista_de_numeros,n,  inicio, meio);
             MergeSort(lista_de_numeros,n, meio+1, fim);
             Merge_order(lista_de_numeros, n, inicio, meio, fim);
        }

    }

    private static void Merge_order(int[] lista_de_numeros, int[] n, int inicio, int meio, int fim)
    {
        for(int k = inicio; k <= fim; k++)
        {
            n[k] = lista_de_numeros[k];
        }
        int i = inicio;
        int j = meio + 1;

        for(int k = inicio; k <=fim; k++)
        {
            if (i > meio) lista_de_numeros[k] = n[k++];
            else if (j > fim) lista_de_numeros[k] = n[i++];
            else if (n[i] < n[j]) lista_de_numeros[k] =n[i++];
            else lista_de_numeros[k] = n[j++];

        }
    }
}