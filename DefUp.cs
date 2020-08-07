using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    class DefUp : SupportSkill
    {
        public float SupportSkillDefUp(float baseDefense)
        {
            float atkUp;
            atkUp = baseDefense * 0.2f;
            return atkUp;
        }
    }
}
