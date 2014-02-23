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
    public partial class frmMusic : Form
    {
        private SoundPlayer player;
        
        public frmMusic()
        {
            InitializeComponent();
            player = new SoundPlayer();
        }

        private void pic1UP_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.snd1UP;
            player.Play();
        }

        private void picTreasure_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndTreasureBox;
            player.Play();
        }

        private void picDead_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndDeath;
            player.Play();
        }

        private void picLevel_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndLevelClear;
            player.Play();
        }

        private void picTail_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndTail;
            player.Play();
        }

        private void picThreeCards_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndThreeCards;
            player.Play();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
        }
    }
}
