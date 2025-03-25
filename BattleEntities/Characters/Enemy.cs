namespace BattleEntities.Characters
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;

        public Enemy(string name) { Name = name; }

        public Enemy() { }
    }
}
