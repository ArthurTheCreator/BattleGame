namespace BattleEntities.Actions.ActionResult;

public class TakePotionResult
{
    public bool IsTake { get; private set; }
    public string? message { get; private set; }

    public TakePotionResult PlayerSuccessTakePotion()
    {
        IsTake = true;
        message = "Você bebe a poção e sente uma energia revitalizante! +20 de vida.";
        return this;
    }

    public TakePotionResult PlayerFailureTakePotionStock()
    {
        message = "Você revira a mochila... nenhuma poção encontrada!";
        return this;
    }

    public TakePotionResult PlayerFailureTakePotionHP()
    {
        message = "Você não sente necessidade - seus ferimentos são leves demais para usar agora.";
        return this;
    }

    public TakePotionResult PlayerFailureTakePotionStockAndHP()
    {
        message = "Sem poções no estoque e você nem precisa - está com a saúde perfeita!";
        return this;
    }

    public TakePotionResult EnemySuccessTakePotion()
    {
        IsTake = true;
        message = "Você bebe a poção e sente uma energia revitalizante! +20 de vida.";
        return this;
    }

}