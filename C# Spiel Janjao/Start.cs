using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Spiel_Janjao
{
    public partial class Start : Form
    {
        private int enemydamageradius = 60;
        private int enemyHealth = 100;
        int enemydamage = 2;
        private int playerHealth = 100;
        int playerdamage = 10;
        int XPamount = 0;
        int weapondamage = 0;
        private int distance = 7;
        private bool movingUp, movingDown, movingLeft, movingRight;
        Label PlayerhealthLabel = new Label();
        public Start()
        {
            InitializeComponent();
            UpdatePlayerHealthLabel();
            UpdateHealthLabel();
            this.KeyPreview = true;
            this.KeyDown += MoveControl;
            this.KeyUp += Start_KeyUp;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateHealthLabelPosition()
        {
            // Update health label position relative to the picture box
            healthLabel.Location = new Point(
                pictureBox2.Left + (pictureBox1.Width - healthLabel.Width) / 2,
                pictureBox2.Top - healthLabel.Height - 5); // Adjust the vertical offset as needed
        }
        private void UpdateHealthLabel()
        {
            // Update health label text with current health value
            healthLabel.Text = $"Health: {enemyHealth}";
        }
        private void UpdatePlayerHealthLabelPosition()
        {
            // Update health label position relative to the picture box
            PlayerhealthLabel.Location = new Point(
                pictureBox1.Left - 25, pictureBox1.Top - 25); // Adjust the vertical offset as needed
        }
        private void UpdatePlayerHealthLabel()
        {
            // Update health label text with current health value
            PlayerhealthLabel.Text = $"Health: {playerHealth}";

            PlayerhealthLabel.AutoSize = true;
            PlayerhealthLabel.Font = new Font("Calibri", 10);
            PlayerhealthLabel.ForeColor = Color.Black;
            PlayerhealthLabel.Padding = new Padding(6);
            this.Controls.Add(PlayerhealthLabel);
        }
        private void UpdateXPLabel()
        {
            label1.Text = $"XP: {XPamount}";
        }
        private void MoveControl(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    movingUp = true;
                    break;
                case Keys.S:
                    movingDown = true;
                    break;
                case Keys.A:
                    movingLeft = true;
                    break;
                case Keys.D:
                    movingRight = true;
                    break;
            }
        }



        private void Start_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    movingUp = false;
                    break;
                case Keys.S:
                    movingDown = false;
                    break;
                case Keys.A:
                    movingLeft = false;
                    break;
                case Keys.D:
                    movingRight = false;
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movingRight && pictureBox1.Right + distance <= ClientSize.Width)
            {
                pictureBox1.Left = Math.Min(ClientSize.Width - pictureBox1.Width, pictureBox1.Left + distance);
            }
            if (movingLeft && pictureBox1.Left - distance >= 0)
            {
                pictureBox1.Left = Math.Max(0, pictureBox1.Left - distance);
            }
            if (movingDown && pictureBox1.Bottom + distance <= ClientSize.Height)
            {
                pictureBox1.Top = Math.Min(ClientSize.Height - pictureBox1.Height, pictureBox1.Top + distance);
            }
            if (movingUp && pictureBox1.Top - distance >= 75)
            {
                pictureBox1.Top = Math.Max(0, pictureBox1.Top - distance);
            }

            if (pictureBox2.Location.X < pictureBox1.Location.X + 50)
            {
                pictureBox2.Left = Math.Min(ClientSize.Width - pictureBox2.Width, pictureBox2.Left + (distance / 3));
            }
            if (pictureBox2.Location.X > pictureBox1.Location.X - 50)
            {
                pictureBox2.Left = Math.Max(0, pictureBox2.Left - (distance / 3));
            }


            if (pictureBox2.Location.Y < pictureBox1.Location.Y + 50)
            {
                pictureBox2.Top = Math.Min(ClientSize.Height - pictureBox2.Height, pictureBox2.Top + (distance / 3));
            }
            if (pictureBox2.Location.Y > pictureBox1.Location.Y - 50)
            {
                pictureBox2.Top = Math.Max(0, pictureBox2.Top - (distance / 3));
            }

            UpdateHealthLabelPosition();
            UpdatePlayerHealthLabelPosition();
            CheckPLayerDamage();
        }


        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void takeDMG(object sender, EventArgs e)
        {
            enemyHealth -= playerdamage + weapondamage; // You can adjust the amount of damage per click

            // Update health bar
            UpdateHealthLabel(); // Update health label

            // Check if enemy health is zero or below
            if (enemyHealth <= 0)
            {
                XPamount += 10;
                UpdateXPLabel();
                // Remove the enemy from the form
                Controls.Remove(pictureBox2);
                pictureBox2.Dispose(); // Clean up resources
                Controls.Remove(healthLabel); // Remove health label if enemy is defeated
            }
            else
            {
                UpdateHealthLabelPosition(); // Update health label position
            }
        }
        private void PlayerDamage()
        {
            if (playerHealth > 0)
            {
                playerHealth -= enemydamage;
                UpdatePlayerHealthLabel();
            }
            

            if (playerdamage == 0)
            {
                bool Gameover = true;
                if (Gameover)
                {
                    pictureBox1.Dispose();
                }
            }
            else
            {
                UpdatePlayerHealthLabel();
            }
        }
        private void CheckPLayerDamage()
        {
            if(pictureBox2.Location.X <= pictureBox1.Location.X + enemydamageradius && pictureBox2.Location.X >= pictureBox1.Location.X - enemydamageradius)
            {
                if (pictureBox2.Location.Y <= pictureBox1.Location.Y + enemydamageradius && pictureBox2.Location.Y >= pictureBox1.Location.Y - enemydamageradius)
                {
                    PlayerDamage();
                }
            }
            if(playerHealth == 0)
            {
                pictureBox1.Dispose();
                timer1.Stop();
                string gameover = "Game over";
                MessageBox.Show(gameover);
                Application.Exit();
            }
        }
        private void regen()
        {
            if(playerHealth > 0)
            {
                playerHealth += 1;
            }
        }


        private void healthLabel_Click(object sender, EventArgs e)
        {

        }


        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
