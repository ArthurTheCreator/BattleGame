namespace BattleEntities.Actions
{
    public class Defense
    {
        public bool IsDefending { get; set; }

        public Defense(bool isDefending)
        {
            IsDefending = isDefending;
        }

        public Defense() { }
    }
}
