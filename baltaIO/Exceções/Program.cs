namespace Exceções;

class Program
{
    static void Main(string[] args)
    {
        var array = new int[3];

        try 
        { 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            Salvar();

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Verifique o índice do array");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado, tente novamente!");
        }

        Console.ReadLine();
    }

    public static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            throw new Exception("O texto nãpo pode ser nulo ou vazio.");
    }
}
