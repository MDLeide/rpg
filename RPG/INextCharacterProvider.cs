namespace RPG
{
    public interface INextCharacterProvider
    {
        ICharacter GetNextCharacter(IBattle battle);
    }
}