using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging; // for jpg compressor

namespace SNgame
{
    public partial class Form1 : Form
    {

        private List<circles> SNsnake = new List<circles>();
        private circles SNfood = new circles();

        int SNmaxwidth, SNmaxheight, score, highscore;

        Random rad = new Random();

        bool SNgoLeft, SNgoRight, SNgoUp, SNgoDown;



        public Form1()
        {
            InitializeComponent();

            new SNsettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && SNsettings.direction != "right") 
            {
                SNgoLeft = true;
            }

            if (e.KeyCode == Keys.Right && SNsettings.direction != "left") 
            {
                SNgoRight = true;
            }


            if (e.KeyCode == Keys.Up && SNsettings.direction != "down") 
            {
                SNgoUp = true;
            }


            if (e.KeyCode == Keys.Down && SNsettings.direction != "up") 
            {
                SNgoDown = true;
            }

        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                SNgoLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                SNgoRight = false;
            }


            if (e.KeyCode == Keys.Up)
            {
                SNgoUp = false;
            }


            if (e.KeyCode == Keys.Down)
            {
                SNgoDown = false;
            }

        }

        private void startSNgame(object sender, EventArgs e)
        {
            SNrestartgame();

        }

        private void SNsnap(object sender, EventArgs e)
        {
            Label SNshot = new Label();
            //snap shot configuration(size, color, message)
            SNshot.Text = "i scord " + score + " in my snake game! my highscore is " + highscore;
            SNshot.Font = new Font("Ariel", 12, FontStyle.Bold);
            SNshot.ForeColor = Color.LightSeaGreen;
            SNshot.AutoSize = false;
            SNshot.Width = SNpicbox.Width;
            SNshot.Height = 30;
            SNshot.TextAlign = ContentAlignment.MiddleCenter;
            SNpicbox.Controls.Add(SNshot);


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "SNsnapshot snake game";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.Filter = "JPG image file  | *.jpg";
            saveFileDialog.ValidateNames = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK )

            {
                int width = Convert.ToInt32(SNpicbox.Width);
                int height = Convert.ToInt32(SNpicbox.Height);
                Bitmap bitmap = new Bitmap(width, height);
                SNpicbox.DrawToBitmap(bitmap, new Rectangle(0,0, width, height));
                bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);

            }

        }

        private void SNgametimer(object sender, EventArgs e)
        {
            // the direction configuration

            if (SNgoRight)
            {
                SNsettings.direction = "right";
            }
            
            if (SNgoLeft)
            {
                SNsettings.direction = "left";
            }

            if (SNgoUp)
            {
                SNsettings.direction = "up";
            }

            if (SNgoDown)
            {
                SNsettings.direction = "down";
            }
            // end

            for (int SN = SNsnake.Count-1; SN >= 0; SN--)
            {
                if (SN == 0)
                {
                    switch (SNsettings.direction)
                    {
                        case "left":
                            SNsnake[SN].dX--;
                            break;

                        case "right":
                            SNsnake[SN].dX++;
                            break;

                        case "down":
                            SNsnake[SN].dY++;
                            break;

                        case "up":
                            SNsnake[SN].dY--;
                            break;
                    }

                    if (SNsnake[SN].dX < 0)
                    {
                        SNsnake[SN].dX = SNmaxwidth;
                    }

                    if (SNsnake[SN].dX > SNmaxwidth)
                    {
                        SNsnake[SN].dX = 0;
                    }

                    if (SNsnake[SN].dY < 0)
                    {
                        SNsnake[SN].dY = SNmaxheight;
                    }

                    if (SNsnake[SN].dY > SNmaxheight)
                    {
                        SNsnake[SN].dY = 0;
                    }

                    if (SNsnake[SN].dX == SNfood.dX && SNsnake[SN].dY == SNfood.dY)
                    {
                        SNeatfood();
                    }

                    for (int m = 1; m < SNsnake.Count; m++)
                    {
                        if (SNsnake[SN].dX == SNsnake[m].dX && SNsnake[SN].dY == SNsnake[m].dY)
                        {
                            SNgameover();
                        }
                    }



                }
                else
                {
                    SNsnake[SN].dX = SNsnake[SN - 1].dX;
                    SNsnake[SN].dY = SNsnake[SN - 1].dY;
                }
            }
            SNpicbox.Invalidate();
        }
        
        private void SNgamegraphics(object sender, PaintEventArgs e)
        {
            Graphics SNdesign = e.Graphics;

            Brush SNcolor;

            for (int SN = 0; SN < SNsnake.Count; SN++)
            {
                if (SN == 0)
                {
                    SNcolor = Brushes.Gray;
                }
                else
                {
                    SNcolor = Brushes.DarkBlue;

                }

                SNdesign.FillEllipse(SNcolor, new Rectangle
                    (
                    SNsnake[SN].dX * SNsettings.Width,
                    SNsnake[SN].dY * SNsettings.Height,
                    SNsettings.Width, SNsettings.Height
                    ));
            }


            SNdesign.FillEllipse(Brushes.Blue, new Rectangle
                    (
                    SNfood.dX * SNsettings.Width,
                    SNfood.dY * SNsettings.Height,
                    SNsettings.Width, SNsettings.Height
                    ));

        }

        private void SNrestartgame()
        {
            SNmaxwidth = SNpicbox.Width / SNsettings.Width - 1;
            SNmaxheight = SNpicbox.Height / SNsettings.Height - 1;

            SNsnake.Clear();

            SNstartbutton.Enabled = false;
            SNsnapbutton.Enabled = false;

            circles SNhead = new circles { dX = 10, dY = 5 }; 
            SNsnake.Add(SNhead); // adding the head part of the snake to the list

            for (int SN = 0; SN < 10; SN++)
            {
                circles SNbody = new circles();
                SNsnake.Add(SNbody);

            }

            SNfood = new circles { dX = rad.Next(2, SNmaxwidth), dY = rad.Next(2, SNmaxheight) };

            SNtimer.Start();

        }

        private void SNeatfood()
        {
            score += 1;

            SNscore.Text = "Score: " + score;

            circles SNbody = new circles
            {
                dX = SNsnake[SNsnake.Count - 1].dX,
                dY = SNsnake[SNsnake.Count - 1].dY

            };


            SNsnake.Add(SNbody);

            SNfood = new circles { dX = rad.Next(2, SNmaxwidth), dY = rad.Next(2, SNmaxheight) };

        }

        private void SNgameover()
        {
            SNtimer.Stop();
            SNstartbutton.Enabled = true;
            SNsnapbutton.Enabled = true;

            if (score > highscore)
            {
                highscore = score;

                SNhighscore.Text = "highscore: " + Environment.NewLine + highscore;
                SNhighscore.ForeColor = Color.Maroon;
                SNhighscore.TextAlign = ContentAlignment.MiddleCenter;
            }


        }
            

    }
}
