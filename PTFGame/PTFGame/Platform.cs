using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFGame
{
    class Platform : GameObject
    {
        public override void collide(GameObject otherObject)
        {
            otherObject.jumpB = false;
            otherObject.Top = this.Top - otherObject.Height;
        }
    }
}
