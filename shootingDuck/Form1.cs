using System.Media;

namespace shootingDuck
{
    public partial class Form1 : Form
    {

        int first_bird_X, first_bird_Y, second_bird_X, second_bird_Y, third_bird_X, third_bird_Y, score, ammo, ammo_spent, time;

        Image[] birds =
{
            Properties.Resources.black,
            Properties.Resources.red,
            Properties.Resources.colored
        };

        SoundPlayer player = new SoundPlayer();
        string path = Application.StartupPath +"\\shotgun.wav";

        private void gameOver()
        {
            endGameLabel.Visible = true;

            int timePassed = 30 - Convert.ToInt32(time) / 50;

            if (score < 15 && timePassed <= 0)
            {
                endGameLabel.Text = "You can do better! You only killed " + score + " ducks." +
                    " and you spent " + ammo_spent + " bullets! " +
                    "\n \n \nClick Restart to Play again!";
            }
            else if (score < 25 && timePassed <= 0)
            {
                endGameLabel.Text = "Great job! You killed " + score + " and you spent " +
                " " + ammo_spent + " bullets! " +
                "\n \n \nClick Restart to Play Again!";
            }
            else if (score >= 25 && timePassed <= 0)
            {
                endGameLabel.Text = "Fantastic job! You killed " + score + " and you spent " +
                + ammo_spent + " bullets! " +
                "\n \n \nClick Restart to Play Again!";
            }

            else if (score < 15 && timePassed >= 0)
            {
                endGameLabel.Text = "You can do better! You only killed " + score + " ducks." +
                    " and you spent" + ammo_spent + " bullets. You only managed to do this " +
                    "at  " + timePassed + " seconds." +
                    "\n \nClick Restart to Play again!";
            }
            else if (score < 25 && timePassed >= 0)
            {
                endGameLabel.Text = "Great job! You killed " + score + " with" +
                " " + ammo_spent + " bullets. You only managed to do this " +
                    "at  " + timePassed + " seconds." +
                    "\n \nClick Restart to Play again!";
            }
            else if (score >= 25 && timePassed >= 0)
            {
                endGameLabel.Text = "Fantastic job! You killed " + score + " with" +
                " " + ammo_spent + " bullets. You only managed to do this " +
                    "at  " + timePassed + " seconds." +
                    "\n \nClick Restart to Play again!";
            }

            timer1.Enabled = false;
            restartButton.Enabled = true;
            gameOverPanel.Visible = true;
            restartButton.Enabled = true;
            gameOverPanel.Enabled = true;
            gameOverPanel.Dock = DockStyle.Fill;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gamePanel.Visible = true;
            gamePanel.Dock = DockStyle.Fill;
            score = 0;
            time = 1500;
            ammo = 40;
            ammo_spent = 0;
            endGameLabel.Visible = false;
            ammoCounter.Text = "Ammo: " + ammo;
            timeLabel.Text = "Time: " + time / 50;
            scoreCounter.Text = Convert.ToString(score);
            startScreen.Hide();
            gamePanel.Show();
            Random r = new Random();
            setupFirstBaloon();
            setupSecondBaloon();
            setupThirdBaloon();
            timer1.Enabled = true;
        }

        private void gamePanel_Click(object sender, EventArgs e)
        {
            player.SoundLocation = path;
            player.Play();
            ammo--;
            ammo_spent++;
            String lastAmmo = Convert.ToString(ammo);
            ammoCounter.Text = "Ammo: " + lastAmmo;
            if (ammo == 0)
            {
                gameOver();
            }
        }

        public void setupFirstBaloon()
        {
            Random r = new Random();
            firstBird.Image = birds[r.Next(0, 3)];
            first_bird_X = r.Next(-100, -50);
            first_bird_Y = r.Next(80, 120);
            firstBird.Location = new Point(first_bird_X, first_bird_Y);
        }

        public void setupSecondBaloon()
        {
            Random r = new Random();
            secondBird.Image = birds[r.Next(0, 3)];
            second_bird_X = r.Next(-100, -50);
            second_bird_Y = r.Next(130, 170);
            secondBird.Location = new Point(second_bird_X, second_bird_Y);
        }

        public void setupThirdBaloon()
        {
            Random r = new Random();
            thirdBird.Image = birds[r.Next(0, 3)];
            third_bird_X = r.Next(-100, -50);
            third_bird_Y = r.Next(180, 220);
            thirdBird.Location = new Point(third_bird_X, third_bird_Y);
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            gamePanel.Hide();
            gameOverPanel.Hide();
            startScreen.Dock = DockStyle.Fill;
            gamePanel.Dock = DockStyle.Fill;
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            score = 0;
            time = 1500;
            ammo = 40;
            endGameLabel.Visible = false;
            gameOverPanel.Visible = false;
            ammoCounter.Text = "Ammo: " + ammo;
            timeLabel.Text = "Time: " + time / 50;
            scoreCounter.Text = Convert.ToString(score);
            startScreen.Hide();
            gamePanel.Show();
            Random r = new Random();
            setupFirstBaloon();
            setupSecondBaloon();
            setupThirdBaloon();
            timer1.Enabled = true;
        }

        private void clicked_bird(object sender, EventArgs e)
        {
            PictureBox clicked_bird = (PictureBox)sender;
            player.SoundLocation = path;
            player.Play();
            score++;
            scoreCounter.Text = score.ToString();
            ammo--;
            ammo_spent++;
            ammoCounter.Text = "Ammo: " + ammo;
            if (ammo == 0)
            {
                gameOver();
            }
            clicked_bird.Image = null;
            Random r = new Random();
            Console.WriteLine(clicked_bird.Name);
            if (clicked_bird.Name == "firstBird")
            {
                setupFirstBaloon();
            }
            if (clicked_bird.Name == "secondBird")
            {
                setupSecondBaloon();
            }
            if (clicked_bird.Name == "thirdBird")
            {
                setupThirdBaloon();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            firstBird.Location = new Point(first_bird_X, first_bird_Y);
            secondBird.Location = new Point(second_bird_X, second_bird_Y);
            thirdBird.Location = new Point(third_bird_X, third_bird_Y);

            first_bird_X+=3;
            second_bird_X+=3;
            third_bird_X+=3;
            time--;
            timeLabel.Text = "Time: " + time / 50;

            if (time == 0)
            {
                gameOver();
            }

            if (first_bird_X > 720)
            {
                first_bird_X = r.Next(-100, 0);
                first_bird_Y = r.Next(38, 218);
            }
            if (second_bird_X > 720)
            {
                second_bird_X = r.Next(-100, 0);
                second_bird_Y = r.Next(38, 218);
            }
            if (third_bird_X > 720)
            {
                third_bird_X = r.Next(-100, 0);
                third_bird_Y = r.Next(38, 218);
            }
        }
    }
}