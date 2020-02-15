using System;

namespace RPG
{
    public interface IBattle
    {
        IParty PlayerParty { get; set; }
        IParty OpponentParty { get; set; }

        ICharacter ActiveCharacter { get; set; }
        IParty ActiveParty { get; set; }

        event EventHandler<ActiveCharacterChangedEventArgs> ActiveCharacterChanged;
        event EventHandler BattleConcluded;

        void SetActiveCharacter(ICharacter character);
        void Conclude();
    }
}