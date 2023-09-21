using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Tela();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());
            EscolhaOpcao(opcao);
        }

        public static void Tela()
        {
            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for (int i = 0; i <= 38; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 38; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        public static void Opcoes()
        {
            Console.SetCursorPosition(3, 2);
            // A função acima informa onde o cursor deve ser posicionado
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========\n");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void EscolhaOpcao(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Mostrar(); break;
                case 2: Viewer.Mostrar(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Mostrar(); break;
            }
        }
    }
}