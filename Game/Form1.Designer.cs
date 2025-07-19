namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            rocket = new PictureBox();
            bg2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            asteroid1 = new PictureBox();
            asteroid2 = new PictureBox();
            asteroid3 = new PictureBox();
            labelLose = new Label();
            restart = new Button();
            star1 = new PictureBox();
            lableStars = new Label();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rocket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asteroid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asteroid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asteroid3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(0, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(860, 640);
            bg1.SizeMode = PictureBoxSizeMode.StretchImage;
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // rocket
            // 
            rocket.BackgroundImage = (Image)resources.GetObject("rocket.BackgroundImage");
            rocket.Image = (Image)resources.GetObject("rocket.Image");
            rocket.Location = new Point(380, 414);
            rocket.Name = "rocket";
            rocket.Size = new Size(95, 188);
            rocket.SizeMode = PictureBoxSizeMode.StretchImage;
            rocket.TabIndex = 1;
            rocket.TabStop = false;
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -640);
            bg2.Name = "bg2";
            bg2.Size = new Size(860, 640);
            bg2.SizeMode = PictureBoxSizeMode.StretchImage;
            bg2.TabIndex = 2;
            bg2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // asteroid1
            // 
            asteroid1.BackgroundImage = (Image)resources.GetObject("asteroid1.BackgroundImage");
            asteroid1.BackgroundImageLayout = ImageLayout.Center;
            asteroid1.Image = (Image)resources.GetObject("asteroid1.Image");
            asteroid1.Location = new Point(148, -200);
            asteroid1.Name = "asteroid1";
            asteroid1.Size = new Size(130, 192);
            asteroid1.SizeMode = PictureBoxSizeMode.AutoSize;
            asteroid1.TabIndex = 3;
            asteroid1.TabStop = false;
            // 
            // asteroid2
            // 
            asteroid2.BackgroundImage = (Image)resources.GetObject("asteroid2.BackgroundImage");
            asteroid2.BackgroundImageLayout = ImageLayout.Center;
            asteroid2.Image = (Image)resources.GetObject("asteroid2.Image");
            asteroid2.Location = new Point(402, -400);
            asteroid2.Name = "asteroid2";
            asteroid2.Size = new Size(130, 192);
            asteroid2.SizeMode = PictureBoxSizeMode.AutoSize;
            asteroid2.TabIndex = 4;
            asteroid2.TabStop = false;
            // 
            // asteroid3
            // 
            asteroid3.BackgroundImage = (Image)resources.GetObject("asteroid3.BackgroundImage");
            asteroid3.BackgroundImageLayout = ImageLayout.Center;
            asteroid3.Image = (Image)resources.GetObject("asteroid3.Image");
            asteroid3.Location = new Point(730, -250);
            asteroid3.Name = "asteroid3";
            asteroid3.Size = new Size(130, 192);
            asteroid3.SizeMode = PictureBoxSizeMode.AutoSize;
            asteroid3.TabIndex = 5;
            asteroid3.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.FromArgb(0, 0, 64);
            labelLose.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLose.ForeColor = Color.White;
            labelLose.Location = new Point(347, 225);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(156, 39);
            labelLose.TabIndex = 6;
            labelLose.Text = "Game over";
            labelLose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restart
            // 
            restart.BackgroundImage = (Image)resources.GetObject("restart.BackgroundImage");
            restart.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            restart.ForeColor = Color.Snow;
            restart.Location = new Point(347, 283);
            restart.Name = "restart";
            restart.Size = new Size(156, 51);
            restart.TabIndex = 7;
            restart.Text = "restart";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // star1
            // 
            star1.BackgroundImage = (Image)resources.GetObject("star1.BackgroundImage");
            star1.Image = (Image)resources.GetObject("star1.Image");
            star1.Location = new Point(253, -400);
            star1.Name = "star1";
            star1.Size = new Size(62, 59);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 8;
            star1.TabStop = false;
            // 
            // lableStars
            // 
            lableStars.AutoSize = true;
            lableStars.BackColor = Color.FromArgb(0, 0, 64);
            lableStars.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lableStars.ForeColor = Color.White;
            lableStars.Location = new Point(12, 9);
            lableStars.Name = "lableStars";
            lableStars.Size = new Size(113, 39);
            lableStars.TabIndex = 10;
            lableStars.Text = "stars: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 640);
            Controls.Add(lableStars);
            Controls.Add(labelLose);
            Controls.Add(restart);
            Controls.Add(rocket);
            Controls.Add(asteroid3);
            Controls.Add(asteroid2);
            Controls.Add(asteroid1);
            Controls.Add(star1);
            Controls.Add(bg2);
            Controls.Add(bg1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rocket).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)asteroid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)asteroid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)asteroid3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox rocket;
        private PictureBox bg2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox asteroid1;
        private PictureBox asteroid2;
        private PictureBox asteroid3;
        private Label labelLose;
        private Button restart;
        private PictureBox star1;
        private Label lableStars;
    }
}
