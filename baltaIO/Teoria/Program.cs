using System.Text;

namespace Guids;

class Program
{
    static void Main(string[] args)
    {
        #region Guid

        //var id = Guid.NewGuid();
        //id.ToString();

        //id = new Guid("0243ec21-7814-4c4a-85da-37d7d7f9c432");
        //Console.WriteLine(id);
        //Console.ReadLine();

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Concatenação

        //var preco = 10.2;
        //var texto = "O perco do produto é R$" + preco + "apenas na promomção";
        //var texto = string.Format("O preço do produto é {0} apenas na promocao quando {1}", preco, true);

        //var texto = $"O preço do produto é {preco} apenas na promoção";
        ////NA LINHA ACIMA, CASO EU QUIERA QUEBRAR LINHA BASTA APENAS ACRESCENTAR @ APÓS O $ OU ENTÃO \n

        //Console.WriteLine(texto);


        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Comparação de Strings

        //var texto = "Testando";
        //Console.WriteLine(texto.CompareTo("Testando"));
        //Console.WriteLine(texto.CompareTo("Testando errado"));
        //Console.WriteLine(texto.Contains("Testando"));
        //Console.WriteLine(texto.Contains("teste errado"));
        //Console.WriteLine(texto.Contains("Testando", StringComparison.OrdinalIgnoreCase));
        //// A FUNÇÃO ACIMA -- StringComparison.OrdinalIgnoreCase -  IGNORA O CAMELCASE

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region StartsWith e EndsWith

        //var texto = "Este é um teste";
        //Console.WriteLine(texto.StartsWith("Este"));
        //Console.WriteLine(texto.StartsWith("este"));
        //Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        //// A FUNÇÃO ACIMA -- StringComparison.OrdinalIgnoreCase -  IGNORA O CAMELCASE

        //Console.WriteLine(texto.EndsWith("teste"));
        //Console.WriteLine(texto.EndsWith("Teste"));
        //Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase));
        //// A FUNÇÃO ACIMA -- StringComparison.OrdinalIgnoreCase -  IGNORA O CAMELCASE

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Equals

        //var texto = "Este é um texto de teste";

        //Console.WriteLine(texto.Equals("Este é um texto de teste"));
        //Console.WriteLine(texto.Equals("Este é um texto de teste da forma errada"));
        //Console.WriteLine(texto.Equals("ESTE É UM TEXTO DE TESTE", StringComparison.OrdinalIgnoreCase));
        //// A FUNÇÃO ACIMA -- StringComparison.OrdinalIgnoreCase -  IGNORA O CAMELCASE
        //// A FUNÇÃO EQUAL FUNCIONA PARA QULQUER TIPO DE OBJETO COMO PODEMOS VER ABAIXO
        //var teste = 33;
        //Console.WriteLine(teste.Equals(22));

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Índices

        //var texto = "Este é um texto de teste";
        //Console.WriteLine(texto.IndexOf("é um"));
        //// A FUNÇÃO ACIMA PEGA O ÍNDICE (POSIÇÃO NO ARRAY) DO PRIEIRO ITEM DA BUSCA DESEJADO NO EXEMPLO ACIMA "é" CORRESPONDE AO ÍDICE 5
        //Console.WriteLine(texto.LastIndexOf("o"));
        //// A FUNÇÃO ACIMA PEGA O ÍNDICE (POSIÇÃO NO ARRAY) DO ÚLTIMO ITEM DA BUSCA DESEJADO NO EXEMPLO ACIMA "o" CORRESPONDE AO ÍDICE 14

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Métodos adicionais

        //var texto = "Este é um texto de teste";
        //Console.WriteLine(texto.ToLower());
        //Console.WriteLine(texto.ToUpper());
        //// OS DOIS MÉTODOS ACIMA CONVERTEM OS CARACTERES TODOS PARA MAIÚSCULOS OU MINÚSCULOS
        //Console.WriteLine(texto.Insert(5, "AQUI "));
        //Console.WriteLine(texto.Remove(5, 4));
        //// OS DOIS MÉTODOS ACIMA ACRESCENTAM E REMOVEM OS CARACTERES ENTRE PARENTESES NO LOCAL DO ÍNDICE INFORMADO ANTES A ELE, SENDO QUE
        //// PARA REMOBER BASTA INFORMAR O ÍNDICE E A QUANTIDADE DE CARACTERES QUE DESEJA REMOVER
        //Console.WriteLine(texto.Length);
        //// O MÉTODO ACIMA INFORMA QUANTOS CARACTERES CONTEM O ARRAY

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region Manipulando Strings

        //var texto = "Este é um texto de teste";
        //Console.WriteLine(texto.Replace("Este", "Isto"));
        //// O MÉTODO ACIMA SUBSTITUI O PRIMEIRO PELO SEGUNDO ITEM INFORMADO ENTRE "___" E FUNCIONA SOMENTE PARA LETRAS COMO NO EXEMPLO ABAIXO
        //Console.WriteLine(texto.Replace("e", "E"));

        //var divisao = texto.Split(" ");
        //Console.WriteLine(divisao[0]);
        //Console.WriteLine(divisao[1]);
        //Console.WriteLine(divisao[2]);
        //Console.WriteLine(divisao[3]);

        //var resultado = texto.Substring(10, 5);
        //Console.WriteLine(resultado);
        //// O MÉTODO ACIMA PEGA O ÍNDICE INFORMADO '10' E OS SEGUINTES INFORMADOS '5' NO CASO EM TELA A PALAVAR TEXTO PODENDO AINDA SER INTEGRADO COM OUTROS MÉTODOS .LastIndesOf()

        //Console.WriteLine();
        //Console.WriteLine();

        #endregion

        #region StringBuilder

        var texto = new StringBuilder();
        texto.Append("Este é um texto de teste ");
        texto.Append("Continuação 1 ");
        texto.Append("Continuação 2 ");
        texto.Append("Continuação 3 ");
        texto.Append("Continuação 4 ");
        texto.Append("Continuação 5 ");
        texto.Append("FIM.");

        Console.WriteLine(texto);

        #endregion


        Console.ReadLine();
    }
}
