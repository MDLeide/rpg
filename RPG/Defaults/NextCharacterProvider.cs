using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Defaults
{
    public class NextCharacterProvider : INextCharacterProvider
    {
        Dictionary<ICharacter, int> _initiative;

        public NextCharacterProvider(IBattle battle)
        {
            foreach (var character in battle.PlayerParty.Members)
        }

        public ICharacter GetNextCharacter(IBattle battle)
        {
            throw new NotImplementedException();
        }
    }
}
