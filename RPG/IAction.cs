namespace RPG
{
    public interface IAction
    {
        string Name { get; set; }

        void Activate(IBattle battle, ICharacter user, ICharacter target);
        void Activate(IBattle battle, ICharacter user, IParty target);
        void Activate(IBattle battle, ICharacter user, ICharacter[] targets);
        void Activate(IBattle battle, ICharacter user, IParty[] targets);

        /// <summary>
        /// Uses an action that affects the battlefield.
        /// </summary>
        /// <param name="battle"></param>
        /// <param name="user"></param>
        void Activate(IBattle battle, ICharacter user);
    }
}