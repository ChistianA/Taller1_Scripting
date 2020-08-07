using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    public class AttackSkill : Skill
    {
        //Attributes
        static public int power;
        Random random = new Random();

        //Builder
        public AttackSkill()
        {
            power = random.Next(1, 11);
        }

        public int Power { get => power; }

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
