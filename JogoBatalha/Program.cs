using BattleEntities.Actions;
using BattleEntities.Characters;
using BattleEntities.EnumActions;
using JogoBatalha.Round;
using MessageLibrary.Enum;
using MessageLibrary.Message.Player;

Enemy enemy = new Enemy();

var lingua = int.Parse(Console.ReadLine());
var value = (EnumLanguage)Enum.ToObject(typeof(EnumLanguage), lingua);
PlayerMessage.EnumLanguage = value;
Console.WriteLine(PlayerMessage.GetSuccessTakePotionMessage());

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
Console.WriteLine("Qual será sua escolha?\n\n");

foreach (EnumAction action in Enum.GetValues(typeof(EnumAction)))
    Console.WriteLine($"{(int)action} \t {action}");

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
        Console.WriteLine($"\nVida do(a) {player.Name}: {player.Hp}");
        Console.WriteLine($"Vida do inimigo: {enemy.Hp}\n");
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

        if (battleResultPlayer.IsCure)
        {
            if (player.Hp <= 80)
            {
                player.Hp += battleResultPlayer.CureValue;
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Você não pode se curar ainda, sua vida precisa estar abaixo de 80!");
        }
        else if (battleResultPlayer.IsAttack && battleResultEnemy.IsDefense)
        {
            var damage = battleResultPlayer.AttackDamage / 2;
            if (damage > 0)
            {
                Console.WriteLine("O inimigo utilizou defesa!");
                Console.WriteLine($"{player.Name} causou {damage} de dano!");
                enemy.Hp -= damage;
            }
            else
                Console.WriteLine("Você errou o ataque, porém seu inimigo defendeu, que sorte!");
        }
        else if (battleResultPlayer.IsDefense && battleResultEnemy.IsAttack) {
            var damage = battleResultEnemy.AttackDamage / 2;
            if (damage > 0)
            {
                Console.WriteLine($"{player.Name} utilizou defesa!");
                Console.WriteLine($"O inimigo causou {damage} de dano!");
                player.Hp -= damage;
            }
            else
                Console.WriteLine($"O inimigo errou o ataque, porém {player.Name} defendeu, que azar...");
        }
        else if (battleResultPlayer.IsAttack && !battleResultEnemy.IsDefense)
        {
            var damage = battleResultPlayer.AttackDamage;
            if (damage > 0)
            {
                if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                    Console.WriteLine($"{player.Name} causou {damage} de dano no inimigo, um ataque devastador!");
                else
                    Console.WriteLine($"{player.Name} causou {damage} de dano no inimigo!");
            }
            else
                Console.WriteLine("Você errou o ataque, que pena...");
        }
        else if (battleResultEnemy.IsAttack && !battleResultPlayer.IsDefense)
        {
            var damage = battleResultPlayer.AttackDamage;
            if (damage > 0)
            {
                if (battleResultPlayer.AttackType == EnumAction.HeavyAttack)
                    Console.WriteLine($"O inimigo causou {damage} de dano no(a) {player.Name}, um ataque devastador!");
                else
                    Console.WriteLine($"O inimigo causou {damage} de dano no(a) {player.Name}!");
            }
            else
                Console.WriteLine("O inimigo errou o ataque, que sorte...");
        }
    }
}

static void PrintGameName()
{
    Console.WriteLine("==================\n");
    Console.WriteLine("   Arena Mortal   \n");
    Console.WriteLine("==================\n\n");
}