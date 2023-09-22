using System.Globalization;

namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        #region Formatando Moedas

        decimal valor = 10.25m;
        Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

        decimal valorE = 10.25m;
        Console.WriteLine(valorE.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));

        decimal valorD = 10.25m;
        Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

        //MAIS UTILIZADOS abaixo

        decimal valorNumero = 100.257m;
        Console.WriteLine(valorNumero.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

        decimal valorPorcentagem = 100.257m;
        Console.WriteLine(valorPorcentagem.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

        decimal valorCMoeda = 10.25m;
        Console.WriteLine(valorCMoeda.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

        Console.WriteLine("\n\n");
        #endregion

        #region Math

        //Arredondar
        decimal valorMath = 10536.25m;
        Console.WriteLine(Math.Round(valorMath));
        Console.WriteLine();

        //Arredondar para cima
        Console.WriteLine(Math.Ceiling(valorMath));
        Console.WriteLine();

        //Arredondar para baixo
        Console.WriteLine(Math.Floor(valorMath));
        Console.WriteLine();
        Console.WriteLine();

        #endregion



        Console.ReadLine();

    }
}
