namespace BattleEntities.Actions;

public class ReturnAction
{
    public bool IsAttack { get; set; }
    public int AttackDamage { get; set; }

    public bool IsDefense { get; set; }
    public decimal DefenseValue { get; set; }

    public bool IsCure { get; set; }
    public int CureValue { get; set; }

    public void Attack(int Damage)
    {
        IsAttack = true;
        AttackDamage = Damage;
    }

    public void Defense()
    {
        IsDefense = true;
        DefenseValue = 0.5m;
    }

    public void Cure()
    {
        IsCure = true;
        CureValue = 20;
    }
}
