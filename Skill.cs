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
        public int power;
        string[] skillNames = { "Scratch", "Fist", "Knock", "Swip", "Thunder", "Impact" };
        Random random = new Random();
        static public string skillName;
        string skillAffinity;

        //Builder
        public Skill()
        {
            name = skillNames[random.Next(6)];
            skillAffinity = Critters.affinity;
            power = random.Next(1, 11);
        }

        public float SupportSkillAtkUp(float baseAttack)
        {
            power = 0;
            float atkUp;
            atkUp = baseAttack * 0.2f;
            return atkUp;
        }

        public float SupportSkillDefUp(float baseDefense)
        {
            power = 0;
            float atkUp;
            atkUp = baseDefense * 0.2f;
            return atkUp;
        }

        public float SupportSkillSpdDwn(float enemySpeed)
        {
            power = 0;
            float spdDwn;
            spdDwn = enemySpeed * 0.3f;
            return spdDwn;
        }

        public float AffinityMultiplier(float baseAttack, float skillPower, string myAffinity, string targetAffinity)
        {
            float damageValue;
            float affinityMultiplier = 0;
            if (myAffinity == "Dark")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 0.5f; break;
                    case "Light": affinityMultiplier = 2f; break;
                    case "Fire": affinityMultiplier = 1f; break;
                    case "Water": affinityMultiplier = 1f; break;
                    case "Wind": affinityMultiplier = 1f; break;
                    case "Earth": affinityMultiplier = 1f; break;
                }
            }
            if (myAffinity == "Light")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 2f; break;
                    case "Light": affinityMultiplier = 0.5f; break;
                    case "Fire": affinityMultiplier = 1f; break;
                    case "Water": affinityMultiplier = 1f; break;
                    case "Wind": affinityMultiplier = 1f; break;
                    case "Earth": affinityMultiplier = 1f; break;
                }
            }
            if (myAffinity == "Fire")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 1f; break;
                    case "Light": affinityMultiplier = 1f; break;
                    case "Fire": affinityMultiplier = 0.5f; break;
                    case "Water": affinityMultiplier = 2f; break;
                    case "Wind": affinityMultiplier = 1f; break;
                    case "Earth": affinityMultiplier = 0f; break;
                }
            }
            if (myAffinity == "Water")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 1f; break;
                    case "Light": affinityMultiplier = 1f; break;
                    case "Fire": affinityMultiplier = 0.5f; break;
                    case "Water": affinityMultiplier = 0.5f; break;
                    case "Wind": affinityMultiplier = 2f; break;
                    case "Earth": affinityMultiplier = 1f; break;
                }
            }
            if (myAffinity == "Wind")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 1f; break;
                    case "Light": affinityMultiplier = 1f; break;
                    case "Fire": affinityMultiplier = 1f; break;
                    case "Water": affinityMultiplier = 0.5f; break;
                    case "Wind": affinityMultiplier = 0.5f; break;
                    case "Earth": affinityMultiplier = 0.5f; break;
                }
            }
            if (myAffinity == "Earth")
            {
                switch (targetAffinity)
                {
                    case "Dark": affinityMultiplier = 1f; break;
                    case "Light": affinityMultiplier = 1f; break;
                    case "Fire": affinityMultiplier = 1f; break;
                    case "Water": affinityMultiplier = 1f; break;
                    case "Wind": affinityMultiplier = 2f; break;
                    case "Earth": affinityMultiplier = 0.5f; break;
                }
            }

            damageValue = (baseAttack + skillPower) * affinityMultiplier;
            return damageValue;
        }


    }
}
