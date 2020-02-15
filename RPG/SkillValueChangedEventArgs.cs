using System;

namespace RPG
{
    public class SkillValueChangedEventArgs : EventArgs
    {
        public SkillValueChangedEventArgs(ISkill skillChanged, double oldValue, double newValue)
        {
            SkillChanged = skillChanged;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public ISkill SkillChanged { get; }
        public double OldValue { get; }
        public double NewValue { get; }
    }
}