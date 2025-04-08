using BattleEntities.Actions;
using BattleEntities.Characters;
using JogoBatalha.Round;
using MessageLibrary.Enum;
using MessageLibrary.Message.GetMessage;

Enemy enemy = new Enemy();

Console.WriteLine("|Escolha o Idioma | Choose the language | Dili seçin |\n" +
                  "|----------------------------------------------------|\n" +
    "|\t\t     1 - Português\t\t     |\n" +
    "|\t\t     2 - English\t\t     |\n" +
    "|\t\t     3 - Türkçe\t\t\t     |" + "\n" +
    "|====================================================|");

var language = int.Parse(Console.ReadLine());
SetLanguege(language);

for (var i = 0; i < 3; i++)
{
    Console.WriteLine(GetPlayerMessage.GetPlayerSuccessTakePotionMessage);
    //Console.WriteLine(GetEnemyMessage.GetEnemySuccessTakePotionMessage());
}

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
Console.WriteLine("Você pode se defender, se curar e fazer um ataque leve, médio ou pesado (uma ação por turno)");
//Console.WriteLine("Qual será sua escolha?\n\n");

//foreach (EnumAction action in Enum.GetValues(typeof(EnumAction)))
//    Console.WriteLine($"{(int)action} \t {action}");

string choosedAction;
bool wrongChoosedAction = true;
int resultAction = 0;

while (wrongChoosedAction)
{
    ReturnAction battleResultPlayer = new ReturnAction();
    ReturnAction battleResultEnemy = new ReturnAction();
    bool battleContinues = true;
    while (battleContinues)
    {
        Chooses(player, enemy);
        //Console.WriteLine($"\nVida do(a) {player.Name}: {player.Hp}");
        //Console.WriteLine($"Vida do inimigo: {enemy.Hp}\n");
        choosedAction = Console.ReadLine();

        if (int.TryParse(choosedAction, out resultAction) == false)
        {
            Console.WriteLine("Digite certo, por favor!");
            battleContinues = false;
        }
        else
            wrongChoosedAction = false;

        battleResultEnemy = EnemyMoveset.EnemyAction(enemy);

        try
        {
            battleResultPlayer = Round.Battle(player, resultAction, enemy);
        }
        catch (Exception)
        {
            wrongChoosedAction = true;
            break;
        }

        Console.Clear();
        battleContinues = BattleRound.RoundFight(player, enemy, battleResultPlayer, battleResultEnemy);

        Console.WriteLine("Aperte qualquer tecla para continuar...\n");
        Console.ReadKey();
    }
}

static void PrintGameName()
{
    Console.WriteLine("==================\n");
    Console.WriteLine("   Arena Mortal   \n");
    Console.WriteLine("==================\n\n");
}

static void Chooses(Player player, Enemy enemy)
{
    Console.WriteLine("Qual será sua escolha?\n\n");
    Console.WriteLine("1-\t Ataque leve");
    Console.WriteLine("2-\t Ataque Médio");
    Console.WriteLine("3-\t Ataque Pesado");
    Console.WriteLine("4-\t Usar Defesa");
    Console.WriteLine("5-\t Usar poção de Cura");
    Console.WriteLine($"\nVida do(a) {player.Name}: {player.Hp}");
    Console.WriteLine($"Vida do inimigo: {enemy.Hp}\n");
}

static void SetLanguege(int language)
{
    var value = (EnumLanguage)Enum.ToObject(typeof(EnumLanguage), language);
    GetPlayerMessage.EnumLanguage = value;
    GetEnemyMessage.EnumLanguage = value;
}