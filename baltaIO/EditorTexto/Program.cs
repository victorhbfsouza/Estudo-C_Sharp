namespace EditorTexto;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("\n================ EDITOR DE TEXTO C# ================\n");
        Console.WriteLine("Escolha a opção desejada\n");
        Console.WriteLine("1 - Abrir um arquivo");
        Console.WriteLine("2 - Criar um arquivo");
        Console.WriteLine("0 - Sair\n");
        short escolha = short.Parse(Console.ReadLine());

        switch(escolha)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Criar(); break;
            default: Menu(); break;
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("\n================ EDITOR DE TEXTO C# ================");
            Console.WriteLine("----------------    Editar texto     -----------------\n\n");
            Console.Write("Informe o caminho do arquivo que deseja abrir: ");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                Console.Clear(); 
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("\n================ EDITOR DE TEXTO C# ================");
            Console.WriteLine("----------------    Criar texto     ----------------\n\nDigite seu texto abaixo, ou aperte a tecla ESC para sair\n\n");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(texto);

            static void Salvar(string texto)
            {
                Console.Clear();
                Console.WriteLine("Informe o caminho para salvar o arqwuivo");
                var path = Console.ReadLine();

                using (var file = new StreamWriter(path))
                {
                    file.Write(texto);
                }
                Console.WriteLine("\nArquivo salvo com sucesso no caminho informado.\n\nAperte a tecla ENTER e retorne para ao menu inicial");
                Console.ReadLine();
                Menu();
            }
        }
    }
}
