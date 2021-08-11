namespace Breakout
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picDead = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.picBall3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bounce_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lives_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picBall2 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.opening = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.dec1 = new System.Windows.Forms.PictureBox();
            this.winner = new System.Windows.Forms.Label();
            this.dec2 = new System.Windows.Forms.PictureBox();
            this.dec3 = new System.Windows.Forms.PictureBox();
            this.dec4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Lime;
            this.picPaddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPaddle.Location = new System.Drawing.Point(183, 515);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(446, 17);
            this.picPaddle.TabIndex = 1;
            this.picPaddle.TabStop = false;
            // 
            // picDead
            // 
            this.picDead.BackColor = System.Drawing.Color.GhostWhite;
            this.picDead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picDead.Location = new System.Drawing.Point(0, 1052);
            this.picDead.Name = "picDead";
            this.picDead.Size = new System.Drawing.Size(1924, 10);
            this.picDead.TabIndex = 2;
            this.picDead.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Yellow;
            this.GameOver.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.Location = new System.Drawing.Point(680, 468);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(483, 244);
            this.GameOver.TabIndex = 3;
            this.GameOver.Text = "GAME OVER!!!\r\n\r\nPress F1 to Start Over.\r\nPress Esc to leave.";
            this.GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBall3
            // 
            this.picBall3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picBall3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBall3.Location = new System.Drawing.Point(90, 612);
            this.picBall3.Name = "picBall3";
            this.picBall3.Size = new System.Drawing.Size(25, 25);
            this.picBall3.TabIndex = 10;
            this.picBall3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 61);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bounces:";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // bounce_lbl
            // 
            this.bounce_lbl.AutoSize = true;
            this.bounce_lbl.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bounce_lbl.Location = new System.Drawing.Point(229, 654);
            this.bounce_lbl.Name = "bounce_lbl";
            this.bounce_lbl.Size = new System.Drawing.Size(49, 61);
            this.bounce_lbl.TabIndex = 16;
            this.bounce_lbl.Text = "0";
            this.bounce_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bounce_lbl_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 715);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 61);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lives:";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // lives_lbl
            // 
            this.lives_lbl.AutoSize = true;
            this.lives_lbl.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives_lbl.Location = new System.Drawing.Point(188, 715);
            this.lives_lbl.Name = "lives_lbl";
            this.lives_lbl.Size = new System.Drawing.Size(49, 61);
            this.lives_lbl.TabIndex = 25;
            this.lives_lbl.Text = "3";
            this.lives_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lives_lbl_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 593);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 61);
            this.label1.TabIndex = 46;
            this.label1.Text = "Hit Blocks:";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_lbl.Location = new System.Drawing.Point(277, 593);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(49, 61);
            this.points_lbl.TabIndex = 47;
            this.points_lbl.Text = "0";
            this.points_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.points_lbl_MouseMove);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(818, 172);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(29, 29);
            this.picBall.TabIndex = 48;
            this.picBall.TabStop = false;
            // 
            // picBall2
            // 
            this.picBall2.BackColor = System.Drawing.Color.White;
            this.picBall2.Location = new System.Drawing.Point(1883, 995);
            this.picBall2.Name = "picBall2";
            this.picBall2.Size = new System.Drawing.Size(29, 29);
            this.picBall2.TabIndex = 49;
            this.picBall2.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // opening
            // 
            this.opening.AutoSize = true;
            this.opening.BackColor = System.Drawing.Color.Yellow;
            this.opening.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opening.Location = new System.Drawing.Point(532, 468);
            this.opening.Name = "opening";
            this.opening.Size = new System.Drawing.Size(871, 219);
            this.opening.TabIndex = 50;
            this.opening.Text = "Welcome to Bounce N’ Wreck\r\n\r\nPress the S key to Start!!!";
            this.opening.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opening.MouseMove += new System.Windows.Forms.MouseEventHandler(this.opening_MouseMove);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // dec1
            // 
            this.dec1.BackColor = System.Drawing.Color.Yellow;
            this.dec1.Location = new System.Drawing.Point(643, 554);
            this.dec1.Name = "dec1";
            this.dec1.Size = new System.Drawing.Size(31, 31);
            this.dec1.TabIndex = 51;
            this.dec1.TabStop = false;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.Color.Yellow;
            this.winner.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.Location = new System.Drawing.Point(749, 434);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(471, 292);
            this.winner.TabIndex = 52;
            this.winner.Text = "WINNER!!! :D\r\n\r\n(F1) Play Again\r\n(Esc) Exit";
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dec2
            // 
            this.dec2.BackColor = System.Drawing.Color.Yellow;
            this.dec2.Location = new System.Drawing.Point(908, 350);
            this.dec2.Name = "dec2";
            this.dec2.Size = new System.Drawing.Size(31, 31);
            this.dec2.TabIndex = 53;
            this.dec2.TabStop = false;
            // 
            // dec3
            // 
            this.dec3.BackColor = System.Drawing.Color.Red;
            this.dec3.Location = new System.Drawing.Point(1169, 554);
            this.dec3.Name = "dec3";
            this.dec3.Size = new System.Drawing.Size(31, 31);
            this.dec3.TabIndex = 54;
            this.dec3.TabStop = false;
            // 
            // dec4
            // 
            this.dec4.BackColor = System.Drawing.Color.Red;
            this.dec4.Location = new System.Drawing.Point(908, 781);
            this.dec4.Name = "dec4";
            this.dec4.Size = new System.Drawing.Size(31, 31);
            this.dec4.TabIndex = 55;
            this.dec4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.dec4);
            this.Controls.Add(this.dec3);
            this.Controls.Add(this.dec2);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.dec1);
            this.Controls.Add(this.opening);
            this.Controls.Add(this.picBall2);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.points_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lives_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bounce_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBall3);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.picDead);
            this.Controls.Add(this.picPaddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picDead;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox picBall3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bounce_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lives_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picBall2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label opening;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox dec1;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.PictureBox dec2;
        private System.Windows.Forms.PictureBox dec3;
        private System.Windows.Forms.PictureBox dec4;
    }
}

