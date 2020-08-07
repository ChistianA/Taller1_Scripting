using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    public class Critters : Player
    {
        //Attributes
        static public string name;
        List<Skill> skills;
        private AttackSkill attackSkill;
        private AtkUp atkUp;
        private DefUp defUp;
        private SpdDwn spdDwn;

        string[] names = { "Pikachu", "Charmander", "Peckle", "Onion", "Mewtwo", "Magicarp" };
        string[] affinities = { "Dark", "Light", "Fire", "Water", "Wind", "Earth" };
        Random random = new Random();
        static public string affinity;
        static public int baseAttack, 
            baseDefense, 
            baseSpeed, 
            hp;

        //Builder
        public Critters()
        {
            name = names[random.Next(6)];
            baseAttack = random.Next(10, 101);
            baseDefense = random.Next(10, 101);
            baseSpeed = random.Next(1, 51);
            hp = 100;
            affinity = affinities[random.Next(6)];
        }

        public string Name { get => name; set => name = value; }
        public int BaseAttack { get => baseAttack; }
        public int BaseDefense { get => baseDefense; }
        public int BaseSpeed { get => baseSpeed; }
        public int HP { get => hp; }
        public string Affinity { get => affinity;}

        public void AsignSkills(Skill skill)
        {
            for (int i = 0; i < 3; i++)
            {
                int numSkill = random.Next(4);
                switch (numSkill)
                {
                    case 0:
                        atkUp = skill as AtkUp;
                        skills.Add(atkUp);
                        break;
                    case 1:
                        defUp = skill as DefUp;
                        skills.Add(defUp);
                        break;
                    case 2:
                        spdDwn = skill as SpdDwn;
                        skills.Add(spdDwn);
                        break;
                    case 3:
                        attackSkill = skill as AttackSkill;
                        skills.Add(attackSkill);
                        break;
                }
            }
        }
    }
}
