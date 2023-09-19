
Console.WriteLine("\n========= CRONOMETRO C# =========\n");
int segundos = 0;
Console.Write("Digite o tempo em segundos do cronometro: ");
segundos = int.Parse(Console.ReadLine());
Start(segundos);


static void Start(int time)
{
    int currenTime = 0;

    while(currenTime != time)
    {
        Console.Clear();
        Console.WriteLine("\n========= CRONOMETRO C# =========\n");
        currenTime++;
        Console.WriteLine(currenTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("\nCronometro finalizado!\n\nAperte a tecla ENTER e finalize o programa!");
    Console.ReadLine();


}

