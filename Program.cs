Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundos => 10s = 10 segundos");
    Console.WriteLine("M - Minutos => 1m = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja marcar ?");
    Console.WriteLine("----------------------------");

    string opcao = Console.ReadLine().ToLower();
    char tipo = char.Parse(opcao.Substring(opcao.Length - 1, 1));
    int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1));
    int multiplicador = 1;

    if (tipo == 'm')
        multiplicador = 60;

    if (tempo == 0)
        System.Environment.Exit(0);

    PreStart(tempo * multiplicador);

}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Preparado?");
    Thread.Sleep(1000);
    Console.WriteLine("Vamos lá...");
    Thread.Sleep(2000);
    Start(time);

}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finish Time!");
    Thread.Sleep(2500);
    Menu();
}
