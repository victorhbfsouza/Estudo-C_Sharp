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
        Console.WriteLine("1 para SOMA\n2 para SUBTRAÇÃO\n3 para MULTIPLICAÇÃO\n4 para DIVISÃO\nQualquer outro número para encerrar o programa");
        Escolha = int.Parse(Console.ReadLine());

  
        if (Escolha == 1)
        {
            Soma();
            Main();
        }
        else if (Escolha == 2)
        {
            Subtracao();
            Main();
        }
        else if(Escolha == 3)
        {
            Multiplicacao();
            Main();
        }
        else if (Escolha == 4)
        {
            Divisao();
            Main();
        }
        else
        {
            Environment.Exit(0);
        }

        #region FORMA 01 COM SWITCH COMENTADO
        //Console.Clear();
        //float n1 = 0f;
        //float n2 = 0f;

        //Console.WriteLine("Digite o primeiro número: ");
        //n1 = float.Parse(Console.ReadLine());
        //Console.WriteLine("Digite o segundo número: ");
        //n2 = float.Parse(Console.ReadLine());

        //switch (Escolha)
        //{
        //    case 1:
        //        Console.WriteLine("O resultado da soma é: " + (n1 + n2));
        //        Console.ReadLine();
        //        break;
        //    case 2:
        //        Console.WriteLine("O resultado da subtração é: " + (n1 - n2));
        //        Console.ReadLine();
        //        break;
        //    case 3:
        //        Console.WriteLine("O resultado da multiplicação é: " + (n1 * n2));
        //        Console.ReadLine();
        //        break;
        //    case 4:
        //        if (n2 != 0)
        //        {
        //            Console.WriteLine("O resultado da divisão é: " + (n1 / n2));
        //            Console.ReadLine();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Atenção: Divisão por 0 não é permitida.");
        //            Console.ReadLine();
        //        }
        //        break;
        //    default:
        //        Console.ReadLine();
        //        Environment.Exit(0);
        //        break;
        //}
        #endregion
    }
    
    #region FUNÇÕES
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("======== SOMA ========\n");
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nA soma é: " + (n1 + n2));
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("======== SUBTRAÇÃO ========\n");
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nA subtração é: " + (n1 - n2));
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("======== DIVISÃO ========\n");
            Console.Write("Digite o dividendo: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o divisor: ");
            float n2 = float.Parse(Console.ReadLine());
            if (n2 == 0)
            {
                Console.WriteLine("\nNão é possível realizar divisão por 0.\n\n APERTE ENTER E REFAÇA O CÁLCULO");
                Console.ReadLine();
                Divisao();
            }
            else
            {
                Console.WriteLine("\nA divisão é: " + (n1 / n2));
                Console.ReadLine();
            }
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("======== MULTIPLICAÇÃO ========\n");
            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nA multiplicação é: " + (n1 * n2));
            Console.ReadLine();
        }

    #endregion
}
