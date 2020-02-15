using System.Collections.Generic;

namespace RPG
{
    public interface IActionSet
    {
        List<IAction> Actions { get; set; }
    }
}