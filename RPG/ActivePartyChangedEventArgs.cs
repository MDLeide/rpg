using System;

namespace RPG
{
    public class ActivePartyChangedEventArgs : EventArgs
    {
        public IParty OldActiveParty { get; set; }
        public IParty NewActiveParty { get; set; }
    }
}