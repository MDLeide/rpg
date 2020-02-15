using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class BattleController
    {
        INextCharacterProvider _nextCharacterProvider;
        ICharacterActionProvider _actionProvider;
        IActionTargetProvider _actionTargetProvider;
        IActionEvoker _actionEvoker;
        IBattleConclusionDecider _conclusionDecider;

        public void RunBattle(IBattle battle)
        {
            var battleConcluded = false;

            while (!battleConcluded)
            {
                var activeCharacter = _nextCharacterProvider.GetNextCharacter(battle);
                battle.SetActiveCharacter(activeCharacter);

                var action = _actionProvider.GetAction(battle, activeCharacter);
                var target = _actionTargetProvider.GetTarget(battle, activeCharacter, action);
                _actionEvoker.EvokeAction(battle, activeCharacter, action, target);
                battleConcluded = _conclusionDecider.BattleHasConcluded(battle);
            }
        }
    }
}
