
namespace SNgame
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
            this.SNstartbutton = new System.Windows.Forms.Button();
            this.SNsnapbutton = new System.Windows.Forms.Button();
            this.SNpicbox = new System.Windows.Forms.PictureBox();
            this.SNscore = new System.Windows.Forms.Label();
            this.SNhighscore = new System.Windows.Forms.Label();
            this.SNtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SNpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // SNstartbutton
            // 
            this.SNstartbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SNstartbutton.Location = new System.Drawing.Point(702, 12);
            this.SNstartbutton.Name = "SNstartbutton";
            this.SNstartbutton.Size = new System.Drawing.Size(103, 68);
            this.SNstartbutton.TabIndex = 0;
            this.SNstartbutton.Text = "start";
            this.SNstartbutton.UseVisualStyleBackColor = false;
            this.SNstartbutton.Click += new System.EventHandler(this.startSNgame);
            // 
            // SNsnapbutton
            // 
            this.SNsnapbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SNsnapbutton.Location = new System.Drawing.Point(702, 97);
            this.SNsnapbutton.Name = "SNsnapbutton";
            this.SNsnapbutton.Size = new System.Drawing.Size(103, 68);
            this.SNsnapbutton.TabIndex = 1;
            this.SNsnapbutton.Text = "snap";
            this.SNsnapbutton.UseVisualStyleBackColor = false;
            this.SNsnapbutton.Click += new System.EventHandler(this.SNsnap);
            // 
            // SNpicbox
            // 
            this.SNpicbox.BackColor = System.Drawing.Color.Silver;
            this.SNpicbox.Location = new System.Drawing.Point(3, 4);
            this.SNpicbox.Name = "SNpicbox";
            this.SNpicbox.Size = new System.Drawing.Size(677, 638);
            this.SNpicbox.TabIndex = 2;
            this.SNpicbox.TabStop = false;
            this.SNpicbox.Paint += new System.Windows.Forms.PaintEventHandler(this.SNgamegraphics);
            // 
            // SNscore
            // 
            this.SNscore.AutoSize = true;
            this.SNscore.BackColor = System.Drawing.Color.Gray;
            this.SNscore.Location = new System.Drawing.Point(718, 198);
            this.SNscore.Name = "SNscore";
            this.SNscore.Size = new System.Drawing.Size(87, 22);
            this.SNscore.TabIndex = 3;
            this.SNscore.Text = "Score 0";
            // 
            // SNhighscore
            // 
            this.SNhighscore.AutoSize = true;
            this.SNhighscore.BackColor = System.Drawing.Color.Gray;
            this.SNhighscore.Location = new System.Drawing.Point(696, 262);
            this.SNhighscore.Name = "SNhighscore";
            this.SNhighscore.Size = new System.Drawing.Size(109, 22);
            this.SNhighscore.TabIndex = 4;
            this.SNhighscore.Text = "highscore";
            // 
            // SNtimer
            // 
            this.SNtimer.Interval = 40;
            this.SNtimer.Tick += new System.EventHandler(this.SNgametimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(853, 654);
            this.Controls.Add(this.SNhighscore);
            this.Controls.Add(this.SNscore);
            this.Controls.Add(this.SNpicbox);
            this.Controls.Add(this.SNsnapbutton);
            this.Controls.Add(this.SNstartbutton);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "SNsnake game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.SNpicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SNstartbutton;
        private System.Windows.Forms.Button SNsnapbutton;
        private System.Windows.Forms.PictureBox SNpicbox;
        private System.Windows.Forms.Label SNscore;
        private System.Windows.Forms.Label SNhighscore;
        private System.Windows.Forms.Timer SNtimer;
    }
}

