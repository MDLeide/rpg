namespace RPG
{
    public interface IBattleConclusionDecider
    {
        bool BattleHasConcluded(IBattle battle);
    }
}