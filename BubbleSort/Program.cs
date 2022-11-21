using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Olá, seja bem vindo!\nEsse projeto foi feito para avaliacao da sa6 do curso de desenvolvimento de sistemas");
        Menu();
    }

    private static void Menu()
    {
        int[] lista_de_numeros;
        int n;
        Console.WriteLine("Digite a quantidade de valores que serão adicionados:");
        n = int.Parse(Console.ReadLine());
        lista_de_numeros = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o valor que será adicionado a posicao {i}:");
            lista_de_numeros[i] = int.Parse(Console.ReadLine());
        }
        lista_de_numeros = BubbleSort(lista_de_numeros);
        Console.WriteLine("A ordenacao dos numeros é:");
        for (int i = 0; i < lista_de_numeros.Length; i++)
        {
            Console.Write(lista_de_numeros[i] + " ");
        }
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

    private static int[] BubbleSort(int[] lista_de_numeros)
    {
        for(int j = 0; j < lista_de_numeros.Length - 1; j++)
        {
            for (int i = 0; i < lista_de_numeros.Length - 1; i++)
            {
                if (lista_de_numeros[i] > lista_de_numeros[i + 1])
                {
                    int numero_troca_posicao = lista_de_numeros[i];
                    lista_de_numeros[i] = lista_de_numeros[i + 1];
                    lista_de_numeros[i + 1] = numero_troca_posicao;
                }
            }
        }


        return lista_de_numeros;
    }
}
