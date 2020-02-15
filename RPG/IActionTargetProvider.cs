namespace RPG
{
    public interface IActionTargetProvider
    {
        ActionTarget GetTarget(IBattle battle, ICharacter user, IAction action);
    }
}