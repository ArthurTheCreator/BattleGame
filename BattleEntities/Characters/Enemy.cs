using BattleEntities.Actions;

namespace BattleEntities.Characters
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;
        public List<HealthPotion> ListHealthPotion { get; set; } = new List<HealthPotion>() 
        { 
            new HealthPotion(),
            new HealthPotion()
        };

        public Enemy(string name) { Name = name; }

        public Enemy() { }
    }
}
