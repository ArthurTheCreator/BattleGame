using BattleEntities.Actions;
using BattleEntities.Actions.ActionResult;

namespace BattleEntities.Characters
{
    public class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;
        public List<HealthPotion> HealthPotionStock { get; set; } = new List<HealthPotion>()
        {
            new HealthPotion(),
            new HealthPotion()
        };

        public Player(string name) { Name = name; }


        public Player() { }

        public TakePotionResult TakePotion()
        {
            var result = new TakePotionResult();
            if (HealthPotionStock.Count > 0 && Hp <= 80)
            {
                Hp += 20;
                return result.PlayerSuccessTakePotion();
            }

            else if (HealthPotionStock.Count > 0 && Hp > 80)
                return result.PlayerFailureTakePotionHP();

            else if (HealthPotionStock.Count == 0 && Hp > 80)
                return result.PlayerFailureTakePotionStockAndHP();

            else return result.PlayerFailureTakePotionStock();
        }

    }
}