using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    class AtkUp : SupportSkill
    {
        public float SupportSkillAtkUp(float baseAttack)
        {
            float atkUp;
            atkUp = baseAttack * 0.2f;
            return atkUp;
        }
    }
}
