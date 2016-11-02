﻿namespace PTFGame
{
    
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Screen = new System.Windows.Forms.Panel();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.gravity = new System.Windows.Forms.Timer(this.components);
            this.player = new PTFGame.Player();
            this.badDude = new PTFGame.Enemy();
            this.platform1 = new PTFGame.Platform();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badDude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.platform1);
            this.Screen.Controls.Add(this.player);
            this.Screen.Controls.Add(this.badDude);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1006, 837);
            this.Screen.TabIndex = 0;
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 1;
            this.movementTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gravity
            // 
            this.gravity.Enabled = true;
            this.gravity.Interval = 1;
            this.gravity.Tick += new System.EventHandler(this.gravity_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Blue;
            this.player.Location = new System.Drawing.Point(488, 306);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(38, 38);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // badDude
            // 
            this.badDude.BackColor = System.Drawing.Color.Red;
            this.badDude.Location = new System.Drawing.Point(675, 160);
            this.badDude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.badDude.Name = "badDude";
            this.badDude.Size = new System.Drawing.Size(38, 38);
            this.badDude.TabIndex = 1;
            this.badDude.TabStop = false;
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.platform1.Location = new System.Drawing.Point(562, 612);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(318, 55);
            this.platform1.TabIndex = 3;
            this.platform1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 837);
            this.Controls.Add(this.Screen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badDude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Timer movementTimer;
        private Enemy badDude;
        private Player player;
        private System.Windows.Forms.Timer gravity;
        private Platform platform1;
    }
}

