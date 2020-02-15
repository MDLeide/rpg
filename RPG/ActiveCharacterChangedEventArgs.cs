using System;

namespace RPG
{
    public class ActiveCharacterChangedEventArgs : EventArgs
    {
        public ActiveCharacterChangedEventArgs(ICharacter oldActive, ICharacter newActive)
        {
            OldActiveCharacter = oldActive;
            NewActiveCharacter = newActive;
        }

        public ICharacter OldActiveCharacter { get; }
        public ICharacter NewActiveCharacter { get; }        
    }
}