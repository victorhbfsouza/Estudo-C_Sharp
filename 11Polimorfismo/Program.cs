namespace _11Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        //Instanciar Estagiario
        Imposto objetoE = new Estagiario();
        objetoE.valeAlimentação(1000);
        objetoE.valeTransporte(1000);
        Console.WriteLine("============================================");

        //Instanciar Gerente
        Imposto objetoG = new Gerente();
        objetoG.valeAlimentação(5000);
        objetoG.valeTransporte(5000);
        Console.WriteLine("============================================");

        //Instanciar Atendente
        Imposto objetoA = new Atendente();
        objetoA.valeAlimentação(2000);
        objetoA.valeTransporte(2000);
        Console.WriteLine("============================================");
    }
}
