using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFGame
{
    class Player : MovingObject
    {
        public override void collide(GameObject otherObject)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

    }
}


