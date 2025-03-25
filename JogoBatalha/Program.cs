using BattleEntities.Characters;
using BattleEntities.EnumActions;
using JogoBatalha.Round;

Enemy enemy = new Enemy();

PrintGameName();

Console.WriteLine("Bem-vindo, jogadô!");
Console.WriteLine("Qual seu nome?");
string name = Console.ReadLine();

Player player = new Player(name);
Console.Clear();

PrintGameName();
Console.WriteLine("Belo nome, jogadô!");
Console.WriteLine("Vamos começar?\n");

Console.WriteLine("Aperte qualquer tecla para continuar.");
Console.ReadKey();

int duration = 3000;
int interval = 500;

DateTime endTime = DateTime.Now.AddMilliseconds(duration);

while (DateTime.Now < endTime)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();
        PrintGameName();
        string dots = new string('.', i + 1);
        Console.WriteLine("Carregando" + dots);
        Thread.Sleep(interval);
    }
}

Console.Clear();
PrintGameName();

Console.WriteLine("Você vai enfrentar um oponente no seu nível de força!\n");
Console.WriteLine("Você pode se defender, fazer um ataque leve, médio ou pesado e se curar, caso tenha levado dano");
Console.WriteLine("Qual será sua escolha?\n\n");

foreach (EnumAction action in Enum.GetValues(typeof(EnumAction)))
    Console.WriteLine($"{(int)action} \t {action}");

string choosedAction;
bool wrongChoosedAction = true;
int resultAction = 0;

while (wrongChoosedAction)
{
    choosedAction = Console.ReadLine();

    if (int.TryParse(choosedAction, out resultAction) == false)
        Console.WriteLine("Digite certo, por favor!");
    else
        wrongChoosedAction = false;

    try
    {
        Round.Battle(player, resultAction, enemy);
    }
    catch (Exception) 
    {
        wrongChoosedAction = true;
    }
}

static void PrintGameName()
{
    Console.WriteLine("==================\n");
    Console.WriteLine("   Arena Mortal   \n");
    Console.WriteLine("==================\n\n");
}