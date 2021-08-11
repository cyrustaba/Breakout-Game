using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Breakout.Properties;

namespace Breakout
{
    public partial class Form1 : Form
    {
        public int vSpeed;
        public int hSpeed;
        public int vSpeed2;
        public int hSpeed2;
        public int vSpeed3;
        public int hSpeed3;
        public const int row = 5;
        public const int col = 19;
        public int points = 0;
        public int bounce = 0;
        public int lives = 3;
        public PictureBox[,] blocks;
        public SoundPlayer splayer = new SoundPlayer(@"C://temp//blaster.wav");
        public SoundPlayer splayer2 = new SoundPlayer(@"C://temp//endost.wav");
        public SoundPlayer splayer3 = new SoundPlayer(@"C://temp//startupost.wav");

        //this creates our form sheet, Our constructor
        public Form1()
        {
            InitializeComponent();
            picBall.Top = 350;
            picBall.Left = 500;
            vSpeed = 10;
            hSpeed = 10;
            vSpeed2 = 10;
            hSpeed2 = 10;
            vSpeed3 = 30;
            hSpeed3 = 30;
            setBlocks();
            splayer3.Play();
            this.Bounds = Screen.PrimaryScreen.Bounds ;
            GameOver.Visible = false;
            opening.Visible = true;
            picPaddle.Visible = false;
            picBall.Visible = false;
            picBall2.Visible = false;
            dec1.Visible = false;
            dec2.Visible = false;
            dec3.Visible = false;
            dec4.Visible = false;
            winner.Visible = false;
            this.TopMost = true;//bring form to front
            picPaddle.Top = picDead.Top - (picDead.Top / 30);
        }
//creating blocks
        private void setBlocks()
        {
            int blockHeight = 25;
            int blockWidth = 100;
            blocks = new PictureBox[row, col];

            for (int x = 0; x < row; x++)
            {
                    for (int y = 0; y < col; y++)
                    {
                        blocks[x, y] = new PictureBox();
                        blocks[x, y].Width = blockWidth;
                        blocks[x, y].Height = blockHeight;
                        blocks[x, y].Top = blockHeight * x;
                        blocks[x, y].Left = blockWidth * y;
                        blocks[x, y].BackColor = Color.Pink;
                        blocks[x, y].BorderStyle = BorderStyle.Fixed3D;
                        this.Controls.Add(blocks[x, y]);//this physically prints the blocks to the form, "this" refers to the cs file Form1.
                    }
            }
        }
//when cursor moves, paddles follow mouse 
        private void Form1_MouseMove(object sender, MouseEventArgs e)//This is an EVENT HANDLER. It will execute the block of code when our mouse moves in the form.(we set it so its form)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2); // e. "equal to" X "x-coordinate of cursor" -(picPaddle.Width/2) so that the MIDDLE part of the paddle follows the cursor. If you didnt do /2, the cursor would line up with the right side of the paddle!
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        private void opening_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X ;
        }
        private void points_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        private void bounce_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        private void lives_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }
        //button controls during GameOver menu
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                lives = 3;
                lives_lbl.Text = lives.ToString();
                points = 0;
                points_lbl.Text = points.ToString();
                bounce = 0;
                bounce_lbl.Text = bounce.ToString();
                picBall.Top = 350;
                picBall.Left = 500;
                picBall2.Top = 995;
                picBall2.Left = 1883;
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                            blocks[x, y].Visible = true;
                    }
                }
                picPaddle.Visible = true;
                picBall.Visible = true;
                picBall2.Visible = true;
                dec1.Visible = true;
                dec2.Visible = true;
                dec3.Visible = true;
                dec4.Visible = true;
                splayer3.Stop();
                timer1.Enabled = true;
                timer2.Enabled = false;
                timer3.Enabled = true;
                GameOver.Visible = false;
                winner.Visible = false;
            }
            if (e.KeyCode == Keys.S)
            {
                splayer3.Stop();
                picPaddle.Visible = true;
                picBall.Visible = true;
                picBall2.Visible = true;
                dec1.Visible = true;
                dec2.Visible = true;
                dec3.Visible = true;
                dec4.Visible = true;
                opening.Visible = false;
                timer1.Enabled = true;
                timer3.Enabled = true;
            }
        }
//main function where everything happens
        private void timer1_Tick(object sender, EventArgs e)//this is an event handler
        {
//increase the distance (in pixels) from top of form to top of picBall(definition of .Top) by vSpeed. Same for hSpeed.
            picBall.Top += vSpeed; 
            picBall.Left += hSpeed;
//if number of bounces reach this, activate timer2 for ball2 movement
            if (bounce == 10)
            {
                timer2.Enabled = true;
            }
//The following four if statements will keep the ball within the borders of the form: 
            if (picBall.Bottom > this.ClientSize.Height)//when picBall hits bottom border, it changes direction of ball
            {
                vSpeed = -vSpeed;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall.Top < 0)//when picBall top bottom border, it changes direction of ball (idk why it is 0 here)
            {
                vSpeed = -vSpeed;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall.Right > this.ClientSize.Width)//when picBall's left border touches right border of form, it changes direction of ball
            {
                hSpeed = -hSpeed;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall.Right < 0)//when picBall's right border touches right border of form, it changes direction of ball (idk why it is 0 here)
            {
                hSpeed = -hSpeed;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
// when ball collides with paddle, then the following code will execute (note how we put it in timer section)
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) == true)
            {
                vSpeed = -vSpeed;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
//detect collision with the blocks
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (picBall.Bounds.IntersectsWith(blocks[x, y].Bounds) && blocks[x, y].Visible == true) // makes sure that even if the ball does intersect with block, it wont hit invisible block
                    {
                        splayer.Play();
                        blocks[x, y].Visible = false;
                        vSpeed = -vSpeed;
                        bounce += 1;
                        bounce_lbl.Text = bounce.ToString();
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                }
            }
//change color when ball hits paddle
            if (picBall.Bottom >= picPaddle.Top && picBall.Bottom <= picPaddle.Bottom && picBall.Left >= picPaddle.Left && picBall.Right <= picPaddle.Right)
            {
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Random rnd = new Random();
                        blocks[x, y].BackColor = Color.FromArgb(rnd.Next(50, 150), rnd.Next(50, 150), rnd.Next(50, 150));
                        this.BackColor = Color.FromArgb(rnd.Next(50, 150), rnd.Next(50, 150), rnd.Next(50, 150));
                    }
                }
            }
// lose lives when ball hits bottom white bar
            if (picBall.Bounds.IntersectsWith(picDead.Bounds))//picBall.Bounds.IntersectsWith(picDead.Bounds)
            {
                lives = lives - 1;
                lives_lbl.Text = lives.ToString();
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
                vSpeed = -vSpeed;
            }
// when run out of lives, game stops
            if (lives == 0)
            {
                splayer2.Play();
                picPaddle.Visible = false;
                picBall.Visible = false;
                picBall2.Visible = false;
                dec1.Visible = false;
                dec2.Visible = false;
                dec3.Visible = false;
                dec4.Visible = false;
                timer1.Enabled = false;//stop the game 
                timer2.Enabled = false;
                timer3.Enabled = false;
                GameOver.Visible = true;//portray the gameover sign.
            }
//if you hit all blocks, you win
            if (points == 95)
            {
                splayer3.Play();
                picPaddle.Visible = false;
                picBall.Visible = false;
                picBall2.Visible = false;
                dec1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                winner.Visible = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            picBall2.Top -= vSpeed2;
            picBall2.Left -= hSpeed2;
            if (picBall2.Bottom > this.ClientSize.Height)//when picBall hits bottom border, it changes direction of ball
            {
                vSpeed2 = -vSpeed2;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall2.Top < 0)//when picBall top bottom border, it changes direction of ball (idk why it is 0 here)
            {
                vSpeed2 = -vSpeed2;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall2.Right > this.ClientSize.Width)//when picBall's left border touches right border of form, it changes direction of ball
            {
                hSpeed2 = -hSpeed2;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall2.Right < 0)//when picBall's right border touches right border of form, it changes direction of ball (idk why it is 0 here)
            {
                hSpeed2 = -hSpeed2;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall2.Bounds.IntersectsWith(picPaddle.Bounds) == true)
            {
                vSpeed2 = -vSpeed2;
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
            }
            if (picBall2.Bounds.IntersectsWith(picDead.Bounds))//picBall.Bounds.IntersectsWith(picDead.Bounds)
            {
                lives = lives - 1;
                lives_lbl.Text = lives.ToString();
                bounce += 1;
                bounce_lbl.Text = bounce.ToString();
                vSpeed2 = -vSpeed2;
            }
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (picBall2.Bounds.IntersectsWith(blocks[x, y].Bounds) && blocks[x, y].Visible == true) // makes sure that even if the ball does intersect with block, it wont hit invisible block
                    {
                        splayer.Play();
                        blocks[x, y].Visible = false;
                        vSpeed2 = -vSpeed2;
                        bounce += 1;
                        bounce_lbl.Text = bounce.ToString();
                        points += 1;
                        points_lbl.Text = points.ToString();
                    }
                }
            }
            if (picBall2.Bottom >= picPaddle.Top && picBall2.Bottom <= picPaddle.Bottom && picBall2.Left >= picPaddle.Left && picBall2.Right <= picPaddle.Right)
            {
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        Random rnd = new Random();
                        blocks[x, y].BackColor = Color.FromArgb(rnd.Next(50, 150), rnd.Next(50, 150), rnd.Next(50, 150));
                        this.BackColor = Color.FromArgb(rnd.Next(50, 150), rnd.Next(50, 150), rnd.Next(50, 150));
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            dec1.Top -= vSpeed3;
            dec2.Left -= hSpeed3;
            dec3.Top += vSpeed3;
            dec4.Left += hSpeed3;

            if (dec1.Bottom > this.ClientSize.Height)//when picBall hits bottom border, it changes direction of ball
            {
                vSpeed3 = -vSpeed3;
            }
            if (dec1.Top < 0)//when picBall top bottom border, it changes direction of ball (idk why it is 0 here)
            {
                vSpeed3 = -vSpeed3;
            }
            if (dec2.Right > this.ClientSize.Width)//when picBall's left border touches right border of form, it changes direction of ball
            {
                hSpeed3 = -hSpeed3;
            }
            if (dec2.Right < 0)//when picBall's right border touches right border of form, it changes direction of ball (idk why it is 0 here)
            {
                hSpeed3 = -hSpeed3;
            }
            if (dec3.Bottom > this.ClientSize.Height)//when picBall hits bottom border, it changes direction of ball
            {
                vSpeed3 = -vSpeed3;
            }
            if (dec3.Top < 0)//when picBall top bottom border, it changes direction of ball (idk why it is 0 here)
            {
                vSpeed3 = -vSpeed3;
            }
            if (dec4.Right > this.ClientSize.Width)//when picBall's left border touches right border of form, it changes direction of ball
            {
                hSpeed3 = -hSpeed3;
            }
            if (dec4.Right < 0)//when picBall's right border touches right border of form, it changes direction of ball (idk why it is 0 here)
            {
                hSpeed3 = -hSpeed3;
            }
        }
    }
}