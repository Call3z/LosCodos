using System;
using System.Windows.Forms;

namespace inlämningsuppgiftShotgun1
{
    public partial class Form1 : Form
    {
        public void CompScore(string txtBoxInput2)
        {
            txtBoxComp.Text = txtBoxInput2;
            string txtInput2 = txtBoxComp.Text;
            var computerAmmo = int.Parse(txtInput2);
            computerAmmo++;
            txtBoxComp.Text = computerAmmo.ToString();
        }

        public void PlayerScore(string txtBoxInput1)
        {
            txtBoxPlayer.Text = txtBoxInput1;
            string txtInput = txtBoxPlayer.Text;
            var playerAmmo = int.Parse(txtInput);
            playerAmmo++;
            txtBoxPlayer.Text = playerAmmo.ToString();
        }

        public void PlayerShoot()
        {
            var value1 = txtBoxPlayer.Text;
            var value2 = int.Parse(value1);
            value2--;
            txtBoxPlayer.Text = value2.ToString();
        }

        public void ComputerShoot()
        {
            var value1 = txtBoxComp.Text;
            var value2 = int.Parse(value1);
            value2--;
            txtBoxComp.Text = value2.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            txtBoxPlayer.Text = "0";
            txtBoxComp.Text = "0";

            var checkButton = int.Parse(txtBoxPlayer.Text);

            if (checkButton == 0)
            {
                btnShoot.Enabled = false;
            }

            if (checkButton != 0)
            {
                btnShoot.Enabled = true;
            }

            if (checkButton < 3)
            {
                btnShotgun.Enabled = false;
            }

            if (checkButton >= 3)
            {
                btnShotgun.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PlayerScore(txtBoxPlayer.Text);
            var checkComputerAmmo = int.Parse(txtBoxComp.Text);
            var checkButton = int.Parse(txtBoxPlayer.Text);
            if (checkButton == 0)
            {
                btnShoot.Enabled = false;
            }
            if (checkButton != 0)
            {
                btnShoot.Enabled = true;
            }
            if (checkButton < 3)
            {
                btnShotgun.Enabled = false;
            }
            if (checkButton >= 3)
            {
                btnShotgun.Enabled = true;
            }
            if (checkComputerAmmo != 0 && checkComputerAmmo < 3)
            {   Random compRandom = new Random();
                int val1 = compRandom.Next(1, 4);
                if (val1 == 1)
                {
                CompScore(txtBoxComp.Text);
                MessageBox.Show("Computer loads once");
                }
                if (val1 == 2)
                {
                MessageBox.Show("Computer blocks");
                 }
                if (val1 == 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Computer shot - You lose! \n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

            if (checkComputerAmmo == 0)
            {
                Random compRandom = new Random();
                var val1 = compRandom.Next(1, 3);
                
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }

                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
            }

            if (checkComputerAmmo >= 3)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 5);

                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }

                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }

                if (val1 == 3)
                {
                    DialogResult dialogResult = MessageBox.Show("Computer shot - You lose!\n Want to try again?", "Exit", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                if (val1 == 4)
                {
                    DialogResult dialogResult = MessageBox.Show("Computer used Shotgun - You lose!\n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

    }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            
            var checkComputerAmmo = int.Parse(txtBoxComp.Text);
            if (checkComputerAmmo != 0 && checkComputerAmmo <3)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 4);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
                if (val1 == 3)
                {
                    ComputerShoot();
                    MessageBox.Show("Computer shoots - You blocked it!");
                }
            }
            if (checkComputerAmmo == 0)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 3);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
            }
            if (checkComputerAmmo >= 3)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 5);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks"); //todo fixa så dator blir av med skott
                }
                if (val1 == 3)
                {
                    MessageBox.Show("Computer shoots - You blocked it!"); //todo fixa så du blir av med skott
                }
                if (val1 == 4)
                {
                    DialogResult dialogResult = MessageBox.Show("Computer used Shotgun - You lose!\n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }
            }

        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            var checkComputerAmmo = int.Parse(txtBoxComp.Text);
            PlayerShoot();
            var checkButton = int.Parse(txtBoxPlayer.Text);
            if (checkButton == 0)
            {
                btnShoot.Enabled = false;
            }
            if (checkButton != 0)
            {
                btnShoot.Enabled = true;
            }
            if (checkButton < 3)
            {
                btnShotgun.Enabled = false;
            }
            if (checkButton >= 3)
            {
                btnShotgun.Enabled = true;
            }
            if (checkComputerAmmo != 0 && checkComputerAmmo < 3)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 4);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    DialogResult dialogResult = MessageBox.Show("You shot when computer was loading! You won! \n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
                if (val1 == 3)
                {
                    ComputerShoot();
                    MessageBox.Show("Computer shoots - Its a tie!");
                }
            }
            if (checkComputerAmmo == 0)
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 3);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    DialogResult dialogResult = MessageBox.Show("You show when computer was loading! You won! \n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
            }
            if (checkComputerAmmo >= 3 )
            {
                Random compRandom = new Random();
                int val1 = compRandom.Next(1, 5);
                if (val1 == 1)
                {
                    CompScore(txtBoxComp.Text);
                    MessageBox.Show("Computer loads once");
                }
                if (val1 == 2)
                {
                    MessageBox.Show("Computer blocks");
                }
                if (val1 == 3)
                {
                    MessageBox.Show("Computer shoots - Its a tie!");
                }
                if (val1 == 4)
                {
                    DialogResult dialogResult = MessageBox.Show("Computer used Shotgun and won! \n Want to try again?", "Exit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }

                }
            }
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            var checkPlayerAmmo = int.Parse(txtBoxPlayer.Text);
            if (checkPlayerAmmo >= 3)
            {
                btnShotgun.Enabled = true;
            }
            DialogResult dialogResult = MessageBox.Show("You used Shotgun and won! \n Want to try again?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {              
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
    }
    
}
