using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Menu();

    }

    private static void Menu()
    {
        int[] valores;
        Console.WriteLine("Quantos valores você deseja adicionar?");
        int tamanho = int.Parse(Console.ReadLine());
        valores = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o valor que será adicionado a posicao {i + 1}:");
            valores[i] = int.Parse(Console.ReadLine());
        }
        Merge_Sort(valores, 0, valores.Length - 1);
        Console.WriteLine(String.Join(" ", valores));
        Fechar();
    }

    private static void Fechar()
    {
        Console.WriteLine("Deseja fazer uma nova ordenacao? \n1 - Sim\n2 - Nao, quero sair da aplicacao!");
        string op = Console.ReadLine();
        switch (op)
        {
            case "1":
                Menu();
                break;
            case "2":
                Console.WriteLine("Obrigado por utilizar minha aplicacao");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("A tecla digitada nao corresponde a nenhuma das alternativas! Escolha a opcao correta");
                Fechar();
                break;
        }
    }

    private static void Merge_Sort(int[] valores, int ini, int fim)
    {
        if (ini < fim)
        {
            int meio = (ini + fim) / 2;
            Merge_Sort(valores, ini, meio);
            Merge_Sort(valores, meio + 1, fim);
            Order_Sort(valores, ini, meio, fim);
            Console.WriteLine(String.Join(" ", valores));

        }
    }

    private static void Order_Sort(int[] valores, int ini, int meio, int fim)
    {
        int i, j, k, troca_posicao;

        i = ini;
        j = meio + 1;
        k = fim;

        while (i <= meio && j <= fim)
        {
            
            for (int x = i; x < j; x++)
            {
                if (valores[x] > valores[x + 1])
                {
                    troca_posicao = valores[x];
                    valores[x] = valores[x + 1];
                    valores[x + 1] = troca_posicao;
                }
            }
            for (int x = j; x < k; x++)
            {
                if (valores[x] > valores[x + 1])
                {
                    troca_posicao = valores[x];
                    valores[x] = valores[x + 1];
                    valores[x + 1] = troca_posicao;
                }
            }
            for (int x = i; x < k; x++)
            {
                if (valores[x] > valores[x + 1])
                {
                    troca_posicao = valores[x];
                    valores[x] = valores[x + 1];
                    valores[x + 1] = troca_posicao;
                }
            }
            i++;
            j++;
        }
        for (int x = ini; x < k; x++)
        {
            if (valores[x] > valores[x + 1])
            {
                troca_posicao = valores[x];
                valores[x] = valores[x + 1];
                valores[x + 1] = troca_posicao;
            }
        }

    }
}
