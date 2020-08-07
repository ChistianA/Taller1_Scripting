using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    public class Skill : Critters
    {
        //Attributes
        string[] skillNames = { "Scratch", "Fist", "Knock", "Swip", "Thunder", "Impact" };
        Random random = new Random();
        static public string skillName;
        string skillAffinity;
        int power;

        //Builder
        public Skill()
        {
            name = skillNames[random.Next(6)];
            skillAffinity = Critters.affinity;
        }

        



    }
}
