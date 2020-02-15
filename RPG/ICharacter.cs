using System.Collections.Generic;

namespace RPG
{
    public interface ICharacter
    {
        string Name { get; set; }
        int MaxHealth { get; set; }
        int CurrentHealth { get; set; }
        int MaxMana { get; set; }
        int CurrentMana { get; set; }

        IAttributeSet Attributes { get; set; }
        ISkillSet Skills { get; set; }

        IActionSet BattleActions { get; set; }
        IActionSet MapActions { get; set; }

        List<IEffect> ActiveEffects { get; set; }
    }
}