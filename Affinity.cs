using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    class Affinity : Critters
    {
        public enum EAffinityType
        {
            Dark,
            Light,
            Fire,
            Wather,
            Wind,
            Earth
        }

        public EAffinityType AffinityType { get; private set; }
    }
}
