using BattleEntities.Actions.Attacks;
using BattleEntities.Characters;
using BattleEntities.EnumActions;
using JogoBatalha.Round;

Enemy enemy = new Enemy();

PrintGameName();

Console.WriteLine("Bem-vindo, jogadô!");
Console.WriteLine("Qual seu nome?");
string name = Console.ReadLine();

Console.Clear();

PrintGameName();
Console.WriteLine("Belo nome, jogadô!");
Console.WriteLine("Vamos começar?");

Player player = new Player(name);

Round.Battle(play, EnumAction.HeavyAttack, ini);

static void PrintGameName()
{
    Console.WriteLine("==================\n");
    Console.WriteLine("   Arena Mortal   \n");
    Console.WriteLine("==================\n\n");
}