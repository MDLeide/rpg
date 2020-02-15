using System.Collections.Generic;

namespace RPG
{
    public interface IAttributeSet
    {
        Dictionary<IAttribute, double> AttributeValues { get; set; }
    }
}