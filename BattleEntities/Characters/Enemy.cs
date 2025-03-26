using BattleEntities.Actions;
using BattleEntities.Actions.ActionResult;

namespace BattleEntities.Characters
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;
        public List<HealthPotion> HealthPotionStock { get; set; } = new List<HealthPotion>() 
        { 
            new HealthPotion(),
            new HealthPotion()
        };

        public Enemy(string name) { Name = name; }

        public Enemy() { }

        public TakePotionResult TakePotion()
        {
            Hp += 20;
            return new TakePotionResult().EnemySuccessTakePotion();
        }
    }
}
