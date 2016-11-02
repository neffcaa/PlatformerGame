using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFGame
{
    class Player : GameObject
    {
        public override void collide(GameObject otherObject)
        {
            otherObject.BackColor = System.Drawing.Color.Blue;            
        }

    }
}


