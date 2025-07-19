using System.Net.Sockets;

namespace Game
{
    public partial class Form1 : Form
    {
        private bool lose = false;
        private int countStars = 0;
        public Form1()
        {
            InitializeComponent();
            labelLose.Visible = false;
            restart.Visible = false;
            KeyPreview = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 5;
            bg1.Top += speed;
            bg2.Top += speed;

            int speedAsteroid = 7;
            asteroid1.Top += speedAsteroid;
            asteroid2.Top += speedAsteroid;
            asteroid3.Top += speedAsteroid;

            star1.Top += speed;

            if (bg1.Top >= 640)
            {
                bg1.Top = 0;
                bg2.Top = -640;
            }

            if (star1.Top >= 640) 
            {
                star1.Top = -50;
                Random rand = new Random();
                star1.Left = rand.Next(10, 800);
            }

            if (asteroid1.Top >= 640)
            {
                asteroid1.Top = -200;
                Random rand = new Random();
                asteroid1.Left = rand.Next(10, 150);
            }

            if (asteroid2.Top >= 640)
            {
                asteroid2.Top = -250;
                Random rand = new Random();
                asteroid2.Left = rand.Next(280, 430);
            }
            if (asteroid3.Top >= 640)
            {
                asteroid3.Top = -400;
                Random rand = new Random();
                asteroid3.Left = rand.Next(560, 720);
            }
            if (rocket.Bounds.IntersectsWith(asteroid1.Bounds)
                || rocket.Bounds.IntersectsWith(asteroid2.Bounds)
                || rocket.Bounds.IntersectsWith(asteroid3.Bounds))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                restart.Visible = true;
                lose = true;
            }
            if(rocket.Bounds.IntersectsWith(star1.Bounds))
            {
                countStars += 1;
                lableStars.Text = "stars: " + countStars.ToString();
                star1.Top = -50;
                Random rand = new Random();
                star1.Left = rand.Next(10, 800);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;
            int speedRocket = 15;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && rocket.Left > 10)
                rocket.Left -= speedRocket;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && rocket.Right < 850)
                rocket.Left += speedRocket;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            asteroid1.Top = -200;
            asteroid2.Top = -250;
            asteroid3.Top = -400;
            rocket.Left = 380;
            labelLose.Visible = false;
            restart.Visible = false;
            timer1.Enabled = true;
            lose = false;
            countStars = 0;
            lableStars.Text = "stars: " + countStars.ToString();
            star1.Top = 400;
        }
    }
}
