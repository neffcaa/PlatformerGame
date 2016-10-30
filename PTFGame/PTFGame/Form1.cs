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

        bool jump;

        int G = 30;
        int force;

        public Form1()
        {

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true) { Player.Left += 5; }
            if (left == true) { Player.Left -= 5; }

            if (jump == true)
            {
                Player.Top -= force;
                force -= 1;
            }

            if (Player.Top + Player.Height >= Screen.Height)
            {
                Player.Top = Screen.Height - Player.Height;
                jump = false;
            }
            else
            {
                Player.Top += 5;
            }
      

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = G;
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
