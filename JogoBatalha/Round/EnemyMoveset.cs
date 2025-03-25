using BattleEntities.Characters;

namespace JogoBatalha.Round;

public static class EnemyMoveset
{
    public static (Enemy, int) EnemyAction(Enemy enemy)
    {
        switch (enemy)
        {
            case Enemy e when e.Hp > 80:
                break;
            case Enemy e when e.Hp <= 80 && e.PotionStock.Count() > 0:
                break;

        } 
    }
}
