namespace PTFGame
{    
    // Test Comment for Charlie's first commit to branch
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.Player);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(671, 544);
            this.Screen.TabIndex = 0;
            this.Screen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Black;
            this.Player.Location = new System.Drawing.Point(310, 196);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(25, 25);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 544);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
    }
}

