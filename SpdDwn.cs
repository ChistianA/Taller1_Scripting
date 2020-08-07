using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    class SpdDwn : SupportSkill
    {
        static public float SupportSkillSpdDwn(float enemySpeed)
        {
            float spdDwn;
            spdDwn = enemySpeed * 0.3f;
            return spdDwn;
        }
    }
}
