using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MATH
{
    public partial class frmToadGame : Form
    {
        private SoundPlayer player;
        
        public frmToadGame()
        {
            InitializeComponent();
        }

        int coinNumber;

        private void btnOK_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();
            coinNumber = randGen.Next(1, 101);

            txtGuess.Enabled = true;
            txtGuess.Focus();
            
            btnOK.Enabled = false;

            lblToadSpeech.Text = "Alright, that's the spirit!\nGo ahead and take a guess!";

            pic1UP.Hide();

            player = new SoundPlayer();
            player.Stream = Properties.Resources.sndTreasureBox;
            player.Play();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            btnGuess.Enabled = true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess;

            if (int.TryParse(txtGuess.Text, out guess))
            {
                player = new SoundPlayer();
                
                if (guess == coinNumber)
                {
                    lblToadSpeech.Text = "Good job!  You got it right, there were " + coinNumber.ToString() + " coins in my chest! \nHere's a 1-UP for your good guess!\nWant to play again?";

                    btnOK.Enabled = true;
                    btnOK.Focus();

                    txtGuess.Enabled = false;
                    txtGuess.Clear();

                    btnGuess.Enabled = false;

                    pic1UP.Show();

                    player.Stream = Properties.Resources.snd1UP;
                    player.Play();
                }

                else if (guess > coinNumber)
                {
                    lblToadSpeech.Text = guess.ToString() + "?!  No way, Mario, I'm not that rich!  There aren't that many coins in there!\nYou need to guess a smaller number than that!\nGuess again!";

                    txtGuess.Clear();
                    txtGuess.Focus();

                    btnGuess.Enabled = false;

                    player.Stream = Properties.Resources.sndTail;
                    player.Play();
                }

                else if (guess < coinNumber)
                {
                    lblToadSpeech.Text = guess.ToString() + "?!  I'm not that poor, Mario!  There are more coins in there!\nYou need to guess a bigger number than that!\nGuess again!";

                    txtGuess.Clear();
                    txtGuess.Focus();

                    btnGuess.Enabled = false;

                    player.Stream = Properties.Resources.sndTail;
                    player.Play();
                }
            }

            else
            {
                lblToadSpeech.Text = "You pulling my leg, Mario?!\n\'" + txtGuess.Text + "\' isn't a number!\nGuess again!";

                txtGuess.Clear();
                txtGuess.Focus();

                btnGuess.Enabled = false;

                player.Stream = Properties.Resources.sndTail;
                player.Play();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
