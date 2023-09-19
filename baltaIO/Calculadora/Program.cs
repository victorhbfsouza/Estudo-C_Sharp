using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=============================================");
        Console.WriteLine("============= CALCULADORA C# ================");
        Console.WriteLine("=============================================");

        int Escolha = 0;
        Console.WriteLine("\nEscolha abaixo a operação que deseja realizar:\n");
        Console.WriteLine("1 para SOMA\n2 para SUBTRAÇÃO\n3 para MULTIPLICAÇÃO\n4 para DIVISÃO\n5 para encerrar o programa");
        Escolha = int.Parse(Console.ReadLine());

        Console.Clear();
        float n1 = 0f;
        float n2 = 0f;

        Console.WriteLine("Digite o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = float.Parse(Console.ReadLine());

        switch (Escolha)
        {
            case 1:
                Console.WriteLine("O resultado da soma é: " + (n1 + n2));
                Console.ReadLine();
                break;
            case 2:
                Console.WriteLine("O resultado da subtração é: " + (n1 - n2));
                Console.ReadLine();
                break;
            case 3:
                Console.WriteLine("O resultado da multiplicação é: " + (n1 * n2));
                Console.ReadLine();
                break;
            case 4:
                if (n2 != 0)
                {
                    Console.WriteLine("O resultado da divisão é: " + (n1 / n2));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Atenção: Divisão por 0 não é permitida.");
                    Console.ReadLine();
                }
                break;
            default:
                Console.ReadLine();
                Environment.Exit(0);
                break;
        }
    }
}
