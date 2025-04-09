using BattleEntities.Actions;
using BattleEntities.Characters;
using JogoBatalha.Round;
using MessageLibrary.Enum;
using MessageLibrary.Message.Battle;
using MessageLibrary.Message.GetMessage;

Enemy enemy = new Enemy();

Console.WriteLine("|Escolha o Idioma | Choose the language | Dili seçin |\n" +
                  "|----------------------------------------------------|\n" +
    "|\t\t     1 - Português\t\t     |\n" +
    "|\t\t     2 - English\t\t     |\n" +
    "|\t\t     3 - Türkçe\t\t\t     |" + "\n" +
    "|====================================================|\n");

bool wrongChoose = true;
var language = 0;
while (wrongChoose)
{
    int.TryParse(Console.ReadLine(), out language);
    switch (language)
    {
        case 1:
            wrongChoose = false;
            break;
        case 2:
            wrongChoose = false;
            break;
        case 3:
            wrongChoose = false;
            break;
        default:
            Console.WriteLine("Por favor, digite uma opção válida! | Please enter a valid option! | Geçerli bir seçenek gir lütfen!");
            break;
    }
}
EnumLanguage usingLanguage = SetLanguage(language);

Console.Clear();

PrintGameName(usingLanguage);

Console.WriteLine(GetBattleContextMessage.GetBattleContextWelcomeMessage);
string name = Console.ReadLine();

if (name is null)
    name = " ";

Player player = new Player(name);
Console.Clear();

PrintGameName(usingLanguage);
Console.WriteLine(GetBattleContextMessage.GetBattleContextStartGameMessage);

Console.WriteLine(GetBattleContextMessage.GetBattleContextPressAnyKeyMessage);
Console.ReadKey();

int duration = 3000;
int interval = 500;

DateTime endTime = DateTime.Now.AddMilliseconds(duration);

while (DateTime.Now < endTime)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();
        PrintGameName(usingLanguage);
        string dots = new string('.', i + 1);
        Console.WriteLine(GetBattleContextMessage.GetBattleContextLoadingMessage + dots);
        Thread.Sleep(interval);
    }
}

Console.Clear();
PrintGameName(usingLanguage);

Console.WriteLine(GetBattleContextMessage.GetBattleContextPlayerChoose);

string choosedAction;
bool wrongChoosedAction = true;
int resultAction = 0;

MenuChoices(player, enemy);
while (wrongChoosedAction)
{
    ReturnAction battleResultPlayer = new ReturnAction();
    ReturnAction battleResultEnemy = new ReturnAction();
    bool battleContinues = true;
    while (battleContinues)
    {
        choosedAction = Console.ReadLine();

        if (int.TryParse(choosedAction, out resultAction) == false)
            battleContinues = false;
        else
            wrongChoosedAction = false;

        if (battleContinues)
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

        Console.WriteLine($"{GetBattleContextMessage.GetBattleContextPressAnyKeyMessage}\n");
        Console.ReadKey();

        if (battleContinues)
            MenuChoices(player, enemy);
    }
}

static void PrintGameName(EnumLanguage lang)
{
    string title = BattleContext.ArenaTitle[lang];

    Console.WriteLine("==================\n");
    Console.WriteLine($"   {title}   \n");
    Console.WriteLine("==================\n");
}


static void MenuChoices(Player player, Enemy enemy)
{
    Console.WriteLine(GetBattleContextMessage.GetBattleContextMenuChoices(player.Name, player.Hp, enemy.Hp));
}

static EnumLanguage SetLanguage(int language)
{
    EnumLanguage value = (EnumLanguage)Enum.ToObject(typeof(EnumLanguage), language);
    GetPlayerMessage.EnumLanguage = value;
    GetEnemyMessage.EnumLanguage = value;
    GetBattleContextMessage.Language = value;
    return value;
}