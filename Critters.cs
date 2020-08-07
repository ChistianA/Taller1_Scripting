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
            
        }
        
    }
}
