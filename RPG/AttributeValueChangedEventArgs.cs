using System;

namespace RPG
{
    public class AttributeValueChangedEventArgs : EventArgs
    {
        public AttributeValueChangedEventArgs(IAttribute attribute, double oldValue, double newValue)
        {
            AttributeChanged = attribute;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public IAttribute AttributeChanged { get; }
        public double OldValue { get; }
        public double NewValue { get; }
    }
}