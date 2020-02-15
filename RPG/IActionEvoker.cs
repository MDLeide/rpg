namespace RPG
{
    public interface IActionEvoker
    {
        void EvokeAction(IBattle battle, ICharacter user, IAction action, ActionTarget target);
    }
}