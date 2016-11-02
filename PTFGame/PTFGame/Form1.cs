using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTFGame
{
    public partial class Form1 : Form
    {

        bool right;
        bool left;        

        int G = 30;
        int force;

        public Form1()
        {
            
            InitializeComponent();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {    
            if (right == true)
            {
                player.moveRight();
            }
            if (left == true)
            {
                player.moveLeft();
            }
        }

        private void gravity_Tick(object sender, EventArgs e)
        {
            badDude.fall(Screen.Height);
            player.fall(Screen.Height);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            if (player.jumpB != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    
                    force = G;                    
                    player.setJump(G);
                    
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }           

        }

      
    }
}
