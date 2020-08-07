using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting_Taller1
{
    public class Player
    {
        private string name;
        private Critters[] myCritters;

        //Builder
        public Player()
        {
            myCritters = new Critters[3];
        }

    }
}
