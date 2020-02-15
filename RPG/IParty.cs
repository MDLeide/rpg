using System.Collections.Generic;

namespace RPG
{
    public interface IParty
    {
        ICharacter[] Members { get; set; }
        List<IEffect> ActiveEffects { get; set; }
    }
}