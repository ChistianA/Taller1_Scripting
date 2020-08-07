using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    class SupportSkill : Skill
    {
        //Atributes
        int power;

        //Builder
        public SupportSkill()
        {
            power = 0;
        }

        public int Power { get => power; set => power = value; }
    }
}
