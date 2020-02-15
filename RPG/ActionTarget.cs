namespace RPG
{
    public class ActionTarget
    {
        public ActionTarget(ICharacter target)
        {
            TargetType = ActionTargetType.SingleCharacter;
            CharacterTargets = new ICharacter[] {target};
        }

        public ActionTarget(ICharacter[] targets)
        {
            TargetType = ActionTargetType.MultiCharacter;
            CharacterTargets = targets;
        }

        public ActionTarget(IParty target)
        {
            TargetType = ActionTargetType.SingleParty;
            PartyTargets = new IParty[] {target};
        }

        public ActionTarget(IParty[] targets)
        {
            TargetType = ActionTargetType.MultiParty;
            PartyTargets = targets;
        }

        public ActionTarget(IBattle target)
        {
            TargetType = ActionTargetType.Battlefield;
            BattleTarget = target;
        }

        public ActionTargetType TargetType { get; }
        public ICharacter[] CharacterTargets { get; }
        public IParty[] PartyTargets { get; }
        public IBattle BattleTarget { get; }
    }
}