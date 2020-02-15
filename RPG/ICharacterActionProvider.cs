namespace RPG
{
    public interface ICharacterActionProvider
    {
        IAction GetAction(IBattle battle, ICharacter character);
    }
}