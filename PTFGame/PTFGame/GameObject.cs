﻿using System;
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

        public bool jumpB = false;
        int force;

        public void moveRight()
        {
            this.Left += 5;
        }

        public void moveLeft()
        {
            this.Left -= 5;
        }

        public void setJump(int G)
        {
            jumpB = true;
            force = G;
        }


        public void fall(int screenHeight)
        {
            if (jumpB == true)
            {
                this.Top -= force;
                force -= 1;
            }
            if (this.Top + this.Height >= screenHeight)
            {
                this.Top = screenHeight - this.Height;
                jumpB = false;
            }
            else
            {
                this.Top += 5;
            }

        }

    }
}
