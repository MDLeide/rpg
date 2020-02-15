using System.Collections.Generic;

namespace RPG
{
    public interface ISkillSet
    {
        Dictionary<ISkill, double> SkillValues { get; set; }

        double GetSkillValue(string skillName);
    }
}