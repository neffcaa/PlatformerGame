using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTFGame
{
    public abstract class GameObject : PictureBox 
    {


        public abstract void collide(GameObject otherObject);
       
    }
}
