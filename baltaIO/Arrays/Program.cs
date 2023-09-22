namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        #region Criando e atribuindo valores
        
        var meuArray = new int[5] {1, 2, 3, 4, 5 };
        meuArray[3] = 0800;

        Console.WriteLine(meuArray[0]);
        Console.WriteLine(meuArray[1]);
        Console.WriteLine(meuArray[2]);
        Console.WriteLine(meuArray[3]);
        Console.WriteLine(meuArray[4]);
        Console.WriteLine();

        #endregion

        #region Percorrendo Array

        var meuArray1 = new int[5] { 1, 2, 3, 4, 5 };

        for(var index = 0; index < meuArray1.Length; index++)
        {
            Console.WriteLine(meuArray1[index]);
        }

        Console.WriteLine();

        #endregion

        #region ForEach

        var meuArray2 = new int[5] { 10, 9, 8, 7, 6 };

        foreach(var item in meuArray2 )
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        #endregion

        #region Alterando valores

        var array = new int[5];
        var arrayb = array;

        array[3] = 700;
        Console.WriteLine(arrayb[3]);
        Console.WriteLine();

        #endregion

        Console.ReadLine();

    }
}
